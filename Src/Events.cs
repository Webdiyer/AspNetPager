/* AspNetPager source code
Copyright (C) 2003-2013  Webdiyer(http://en.webdiyer.com)

This file is part of AspNetPager.

AspNetPager is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

AspNetPager is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with AspNetPager.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace Wuqi.Webdiyer
{
    public partial class AspNetPager
    {

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Event[@name="PageChanging"]/*'/>
        public event PageChangingEventHandler PageChanging
        {
            add
            {
                Events.AddHandler(EventPageChanging, value);
            }
            remove
            {
                Events.RemoveHandler(EventPageChanging, value);
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Event[@name="PageChanged"]/*'/>
        public event EventHandler PageChanged
        {
            add
            {
                Events.AddHandler(EventPageChanged, value);
            }
            remove
            {
                Events.RemoveHandler(EventPageChanged, value);
            }
        }
    }
}
