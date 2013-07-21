//AspNetPager分页控件源代码：
//版权所有：陕西省延安市吴起县博杨计算机有限公司 杨涛（Webdiyer）
//此源代码仅供学习参考，不得用于任何商业用途；
//您可以修改并重新编译该控件，但源代码中的版权信息必须原样保留！
//有关控件升级及新控件发布信息，请留意 www.webdiyer.com 。

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
