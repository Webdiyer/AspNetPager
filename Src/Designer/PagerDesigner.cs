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
            actionItems.Add(new DesignerActionHeaderItem("Paging mode"));
            actionItems.Add(new DesignerActionPropertyItem("UrlPaging", "enable url paging", "Paging"));
            actionItems.Add(new DesignerActionPropertyItem("UrlPageIndexName", "Url page index parameter name", "Paging"));

            actionItems.Add(new DesignerActionHeaderItem("Appearance"));
            actionItems.Add(new DesignerActionPropertyItem("ShowFirstLast", "Show first and last page buttons", "Appearance"));
            actionItems.Add(new DesignerActionPropertyItem("ShowPrevNext", "Show previous and next page buttons", "Appearance"));
            actionItems.Add(new DesignerActionPropertyItem("CurrentPageButtonPosition", "Current paging button position", "Appearance"));
            actionItems.Add(new DesignerActionMethodItem(this, "ShowAboutForm", "About AspNetPager...", "Help", true));

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
            set { SetProperty("UrlPageIndexName",value); }
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
