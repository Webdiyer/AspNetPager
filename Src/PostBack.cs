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

using System.Collections.Specialized;

namespace Wuqi.Webdiyer
{
    public partial class AspNetPager
    {
        #region IPostBackEventHandler Implementation

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Method[@name="RaisePostBackEvent"]/*'/>
        public void RaisePostBackEvent(string args)
        {
            int pageIndex = CurrentPageIndex;
            try
            {
                if (string.IsNullOrEmpty(args))
                    args = inputPageIndex;
                pageIndex = int.Parse(args);
            }
            catch { }
            PageChangingEventArgs pcArgs = new PageChangingEventArgs(pageIndex);
            if (cloneFrom != null)
                cloneFrom.OnPageChanging(pcArgs);
            else
                OnPageChanging(pcArgs);
        }

        #endregion

        #region IPostBackDataHandler Implementation

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Method[@name="LoadPostData"]/*'/>
        public virtual bool LoadPostData(string pkey, NameValueCollection pcol)
        {
            string str = pcol[UniqueID + "_input"];
            if (str != null && str.Trim().Length > 0)
            {
                try
                {
                    int pindex = int.Parse(str);
                    if (pindex > 0 && pindex <= PageCount)
                    {
                        inputPageIndex = str;
                        Page.RegisterRequiresRaiseEvent(this);
                    }
                }
                catch { }
            }
            return false;
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Method[@name="RaisePostDataChangedEvent"]/*'/>
        public virtual void RaisePostDataChangedEvent() { }

        #endregion
    }
}
