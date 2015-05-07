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

using System.ComponentModel;

namespace Wuqi.Webdiyer
{
    /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Class[@name="PageChangingEventArgs"]/*'/>
    public sealed class PageChangingEventArgs : CancelEventArgs
    {
        private readonly int _newpageindex;

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Constructor[@name="PageChangingEventArgs"]/*'/>
        public PageChangingEventArgs(int newPageIndex)
        {
            _newpageindex = newPageIndex;
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="NewPageIndex"]/*'/>
        public int NewPageIndex
        {
            get { return _newpageindex; }
        }
    }
}
