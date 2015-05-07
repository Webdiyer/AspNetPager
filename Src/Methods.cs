/* AspNetPager source code
This file is part of AspNetPager.

Copyright 2003-2015 Webdiyer(http://en.webdiyer.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Wuqi.Webdiyer
{
    public partial class AspNetPager
    {
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Method[@name="OnPageChanging"]/*'/>
        protected virtual void OnPageChanging(PageChangingEventArgs e)
        {
            //pageChangeEventHandled = true;
            PageChangingEventHandler handler = (PageChangingEventHandler)Events[EventPageChanging];
            if (handler != null)
            {
                handler(this, e);
                if (!e.Cancel || UrlPaging) //there's no way we can obtain the last value of the CurrentPageIndex in UrlPaging mode, so it doesn't make sense to cancel PageChanging event in UrlPaging mode
                {
                    CurrentPageIndex = e.NewPageIndex;
                    OnPageChanged(EventArgs.Empty);
                }
            }
            else
            {
                CurrentPageIndex = e.NewPageIndex;
                OnPageChanged(EventArgs.Empty);
            }
            //pageChangeEventHandled = false;
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Method[@name="OnPageChanged"]/*'/>
        protected virtual void OnPageChanged(EventArgs e)
        {
            EventHandler handler = (EventHandler)Events[EventPageChanged];
            if (handler != null)
                handler(this, e);
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Method[@name="GoToPage"]/*'/>
        public virtual void GoToPage(int pageIndex)
        {
            OnPageChanging(new PageChangingEventArgs(pageIndex));
        }
    }
}
