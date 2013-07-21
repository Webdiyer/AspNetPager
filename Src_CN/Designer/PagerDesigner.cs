using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.IO;

namespace Wuqi.Webdiyer
{

    #region AspNetPager Control Designer
    /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Class[@name="PagerDesigner"]/*'/>
    public class PagerDesigner : System.Web.UI.Design.ControlDesigner
    {

        private AspNetPager wb;

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Method[@name="GetEditableDesignerRegionContent"]/*'/>
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region)
        {
            region.Selectable = false;
            return null;
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Method[@name="GetDesignTimeHtml"]/*'/>
        public override string GetDesignTimeHtml()
        {

            wb = (AspNetPager)Component;
            wb.RecordCount = 225;
            StringWriter sw = new StringWriter();
            HtmlTextWriter writer = new HtmlTextWriter(sw);
            wb.RenderControl(writer);
            return sw.ToString();
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Method[@name="GetErrorDesignTimeHtml"]/*'/>
        protected override string GetErrorDesignTimeHtml(Exception e)
        {
            string errorstr = "Error creating control：" + e.Message;
            return CreatePlaceHolderDesignTimeHtml(errorstr);
        }

        public override DesignerActionListCollection ActionLists
        {
            get
            {
                DesignerActionListCollection actionLists = new DesignerActionListCollection();
                actionLists.Add(new AspNetPagerActionList(this.Component));
                return actionLists;
            }
        }

    }
    /// <summary>
    /// Designer Action List
    /// </summary>
    public class AspNetPagerActionList : DesignerActionList
    {
        private AspNetPager pager;
        private DesignerActionUIService svc = null;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="component"></param>
        public AspNetPagerActionList(IComponent component)
            : base(component)
        {
            pager = component as AspNetPager;
            svc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection actionItems = new DesignerActionItemCollection();
            actionItems.Add(new DesignerActionHeaderItem("Url分页"));
            actionItems.Add(new DesignerActionPropertyItem("UrlPaging", "启用Url分页", "分页"));
            actionItems.Add(new DesignerActionPropertyItem("UrlPageIndexName", "Url页索引参数名称", "分页"));

            actionItems.Add(new DesignerActionHeaderItem("外观及文本"));
            actionItems.Add(new DesignerActionPropertyItem("ShowFirstLast", "显示首页和尾页按钮", "外观"));
            actionItems.Add(new DesignerActionPropertyItem("ShowPrevNext", "显示上一页和下一页按钮", "外观"));
            actionItems.Add(new DesignerActionPropertyItem("CurrentPageButtonPosition", "当前页数字索引按钮的显示位置", "外观"));
            actionItems.Add(new DesignerActionMethodItem(this, "SetPageIndexBox", "页索引文本或下拉框...", "外观", true));
            actionItems.Add(new DesignerActionMethodItem(this, "SetNavText", "导航按钮显示文本...", "外观", true));
            actionItems.Add(new DesignerActionMethodItem(this, "SetCustomInfoHTML", "自定义信息区显示方式及内容...", "外观", true));
            actionItems.Add(new DesignerActionMethodItem(this, "ShowSPWindow", "分页存储过程生成工具...", "工具及帮助", true));
            actionItems.Add(new DesignerActionMethodItem(this, "ShowAboutForm", "关于AspNetPager...", "工具及帮助", true));

            return actionItems;
        }

        public bool UrlPaging
        {
            get
            {
                return pager.UrlPaging;
            }
            set
            {
                SetProperty("UrlPaging", value);
                if (!value)
                    SetProperty("EnableUrlRewriting", false);
            }
        }

        public string UrlPageIndexName
        {
            get { return pager.UrlPageIndexName; }
            set { SetProperty("UrlPageIndexName", value); }
        }

        public bool ShowFirstLast
        {
            get
            {
                return pager.ShowFirstLast;
            }
            set
            {
                SetProperty("ShowFirstLast", value);
            }
        }

        public bool ShowPrevNext
        {
            get
            {
                return pager.ShowPrevNext;
            }
            set
            {
                SetProperty("ShowPrevNext", value);
            }
        }

        public PagingButtonPosition CurrentPageButtonPosition
        {
            get
            {
                return pager.CurrentPageButtonPosition;
            }
            set
            {
                SetProperty("CurrentPageButtonPosition", value);
            }
        }

        public void SetNavText()
        {
            NavTextForm f = new NavTextForm(pager.FirstPageText, pager.LastPageText, pager.PrevPageText, pager.NextPageText);
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetProperty("FirstPageText", f.FirstPageText);
                SetProperty("LastPageText", f.LastPageText);
                SetProperty("PrevPageText", f.PrevPageText);
                SetProperty("NextPageText", f.NextPageText);
            }
        }

        public void SetCustomInfoHTML()
        {
            CustomInfoForm f = new CustomInfoForm(pager.ShowCustomInfoSection,pager.CustomInfoHTML);
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetProperty("ShowCustomInfoSection", f.ShowCustomSection);
                SetProperty("CustomInfoHTML", f.CustomInfoHtml);
            }
        }

        public void SetPageIndexBox()
        {
            PageIndexBoxForm f = new PageIndexBoxForm(pager.ShowPageIndexBox, pager.ShowBoxThreshold, pager.PageIndexBoxType,pager.TextBeforePageIndexBox,pager.TextAfterPageIndexBox,pager.SubmitButtonText);
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SetProperty("ShowPageIndexBox", f.ShowIndexBox);
                SetProperty("ShowBoxThreshold", f.Threshold);
                SetProperty("PageIndexBoxType", f.BoxType);
                SetProperty("TextBeforePageIndexBox", f.TextBeforeBox);
                SetProperty("TextAfterPageIndexBox", f.TextAfterBox);
                SetProperty("SubmitButtonText", f.SubmitButtonText);
            }
        }

        public void ShowSPWindow()
        {
            StoredProcForm f = new StoredProcForm();
            f.ShowDialog();
        }

        public void ShowAboutForm()
        {
            AboutForm f = new AboutForm();
            f.ShowDialog();
        }

        // Helper method to safely set a component’s property
        private void SetProperty(string propertyName, object value)
        {
            // Get property
            PropertyDescriptor property = TypeDescriptor.GetProperties(pager)[propertyName];
            // Set property value
            property.SetValue(pager, value);
        }
    }
    #endregion
}
