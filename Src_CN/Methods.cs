//AspNetPager分页控件源代码：
//版权所有：陕西省延安市吴起县博杨计算机有限公司 杨涛（Webdiyer）
//此源代码仅供学习参考，不得用于任何商业用途；
//您可以修改并重新编译该控件，但源代码中的版权信息必须原样保留！
//有关控件升级及新控件发布信息，请留意 www.webdiyer.com 。

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
