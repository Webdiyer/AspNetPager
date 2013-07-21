/* AspNetPager version 7.4.3
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
