//AspNetPager分页控件源代码：
//版权所有：陕西省延安市吴起县博杨计算机有限公司 杨涛（Webdiyer）
//此源代码仅供学习参考，不得用于任何商业用途；
//您可以修改并重新编译该控件，但源代码中的版权信息必须原样保留！
//有关控件升级及新控件发布信息，请留意 www.webdiyer.com 。



using System;
using System.ComponentModel;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wuqi.Webdiyer
{
    public partial class AspNetPager
    {
        #region Private fields

        private enum NavigationButton : byte
        {
            First, Prev, Next, Last
        }

        //private string cssClassName;
        private string inputPageIndex;
        private string currentUrl;
        private string queryString;
        private AspNetPager cloneFrom;
        private static readonly object EventPageChanging = new object();
        private static readonly object EventPageChanged = new object();
        const string scriptRegItemName = "IsANPScriptsRegistered";
        #endregion

        #region Navigation Buttons

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ShowNavigationToolTip"]/*'/>
        [Browsable(true), ANPCategory("cat_Navigation"), DefaultValue(false), ANPDescription("desc_ShowNavigationToolTip"), Themeable(true)]
        public bool ShowNavigationToolTip
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ShowNavigationToolTip;
                object obj = ViewState["ShowNvToolTip"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                ViewState["ShowNvToolTip"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="NavigationToolTipTextFormatString"]/*'/>
        [Browsable(true), Themeable(true), ANPCategory("cat_Navigation"), ANPDefaultValue("def_NavigationToolTipTextFormatString"), ANPDescription("desc_NavigationToolTipTextFormatString")]
        public string NavigationToolTipTextFormatString
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.NavigationToolTipTextFormatString;
                object obj = ViewState["NvToolTipFormatString"];
                if (obj == null)
                {
                    if (ShowNavigationToolTip)
                        return SR.GetString("def_NavigationToolTipTextFormatString");
                    return null;
                }
                return (string)obj;
            }
            set
            {
                string tip = value;
                if (tip.Trim().Length < 1 && tip.IndexOf("{0}") < 0)
                    tip = "{0}";
                ViewState["NvToolTipFormatString"] = tip;
            }
        }

        /// <include file='AspnetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="NumericButtonTextFormatString"]/*'/>
        [Browsable(true), Themeable(true), DefaultValue(""), ANPCategory("cat_Navigation"), ANPDescription("desc_NBTFormatString")]
        public string NumericButtonTextFormatString
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.NumericButtonTextFormatString;
                object obj = ViewState["NumericButtonTextFormatString"];
                return (obj == null) ? String.Empty : (string)obj;
            }
            set
            {
                ViewState["NumericButtonTextFormatString"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CurrentPageButtonTextFormatString"]/*'/>
        [Browsable(true), Themeable(true), DefaultValue(""), ANPCategory("cat_Navigation"), ANPDescription("desc_CPBTextFormatString")]
        public string CurrentPageButtonTextFormatString
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.CurrentPageButtonTextFormatString;
                object obj = ViewState["CurrentPageButtonTextFormatString"];
                return (obj == null) ? NumericButtonTextFormatString : (string)obj;
            }
            set
            {
                ViewState["CurrentPageButtonTextFormatString"] = value;
            }
        }


        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PagingButtonType"]/*'/>
        [Browsable(true), Themeable(true), DefaultValue(PagingButtonType.Text), ANPCategory("cat_Navigation"), ANPDescription("desc_PagingButtonType")]
        public PagingButtonType PagingButtonType
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.PagingButtonType;
                object obj = ViewState["PagingButtonType"];
                return (obj == null) ? PagingButtonType.Text : (PagingButtonType)obj;
            }
            set
            {
                ViewState["PagingButtonType"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="NumericButtonType"]/*'/>
        [Browsable(true), Themeable(true), DefaultValue(PagingButtonType.Text), ANPCategory("cat_Navigation"), ANPDescription("desc_NumericButtonType")]
        public PagingButtonType NumericButtonType
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.NumericButtonType;
                object obj = ViewState["NumericButtonType"];
                return (obj == null) ? PagingButtonType : (PagingButtonType)obj;
            }
            set
            {
                ViewState["NumericButtonType"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PagingButtonLayoutType"]/*'/>
        [Browsable(true), Themeable(true), DefaultValue(PagingButtonLayoutType.None), ANPCategory("cat_Navigation"), ANPDescription("desc_PagingButtonLayoutType")]
        public PagingButtonLayoutType PagingButtonLayoutType
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.PagingButtonLayoutType;
                object obj = ViewState["PagingButtonLayoutType"];
                return (obj == null) ? PagingButtonLayoutType.None : (PagingButtonLayoutType)obj;
            }
            set { ViewState["PagingButtonLayoutType"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CurrentPageButtonPosition"]/*'/>
        [Browsable(true), Themeable(true), DefaultValue(PagingButtonPosition.Fixed), ANPCategory("cat_Navigation"), ANPDescription("desc_CurrentPageButtonPosition")]
        public PagingButtonPosition CurrentPageButtonPosition
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.CurrentPageButtonPosition;
                object obj = ViewState["CurrentPageButtonPosition"];
                return (obj == null) ? PagingButtonPosition.Fixed : (PagingButtonPosition)obj;
            }
            set { ViewState["CurrentPageButtonPosition"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="NavigationButtonsPosition"]/*'/>
        [Browsable(true), Themeable(true), DefaultValue(NavigationButtonPosition.BothSides), ANPCategory("cat_Navigation"), ANPDescription("desc_NavigationButtonsPosition")]
        public NavigationButtonPosition NavigationButtonsPosition
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.NavigationButtonsPosition;
                object obj = ViewState["NavigationButtonsPosition"];
                return (obj == null) ? NavigationButtonPosition.BothSides : (NavigationButtonPosition)obj;
            }
            set { ViewState["NavigationButtonsPosition"] = value; }

        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="NavigationButtonType"]/*'/>
        [Browsable(true), Themeable(true), ANPCategory("cat_Navigation"), DefaultValue(PagingButtonType.Text), ANPDescription("desc_NavigationButtonType")]
        public PagingButtonType NavigationButtonType
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.NavigationButtonType;
                object obj = ViewState["NavigationButtonType"];
                return (obj == null) ? PagingButtonType : (PagingButtonType)obj;
            }
            set
            {
                ViewState["NavigationButtonType"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="UrlPagingTarget"]/*'/>
        [Browsable(true), Themeable(true), DefaultValue(""), TypeConverter(typeof(TargetConverter)), ANPCategory("cat_Navigation"), ANPDescription("desc_UrlPagingTarget")]
        public string UrlPagingTarget
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.UrlPagingTarget;
                return (string)ViewState["UrlPagingTarget"];
            }
            set
            {
                ViewState["UrlPagingTarget"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="MoreButtonType"]/*'/>
        [Browsable(true), Themeable(true), ANPCategory("cat_Navigation"), DefaultValue(PagingButtonType.Text), ANPDescription("desc_MoreButtonType")]
        public PagingButtonType MoreButtonType
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.MoreButtonType;
                object obj = ViewState["MoreButtonType"];
                return (obj == null) ? PagingButtonType : (PagingButtonType)obj;
            }
            set
            {
                ViewState["MoreButtonType"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PagingButtonSpacing"]/*'/>
        [Browsable(true), Themeable(true), ANPCategory("cat_Navigation"), DefaultValue(typeof(Unit), "5px"), ANPDescription("desc_PagingButtonSpacing")]
        public Unit PagingButtonSpacing
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.PagingButtonSpacing;
                object obj = ViewState["PagingButtonSpacing"];
                return (obj == null) ? Unit.Pixel(5) : (Unit.Parse(obj.ToString()));
            }
            set
            {
                ViewState["PagingButtonSpacing"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ShowFirstLast"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_ShowFirstLast"), ANPCategory("cat_Navigation"), DefaultValue(true)]
        public bool ShowFirstLast
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ShowFirstLast;
                object obj = ViewState["ShowFirstLast"];
                return (obj == null) ? true : (bool)obj;
            }
            set { ViewState["ShowFirstLast"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ShowPrevNext"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_ShowPrevNext"), ANPCategory("cat_Navigation"), DefaultValue(true)]
        public bool ShowPrevNext
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ShowPrevNext;
                object obj = ViewState["ShowPrevNext"];
                return (obj == null) ? true : (bool)obj;
            }
            set { ViewState["ShowPrevNext"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ShowPageIndex"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_ShowPageIndex"), ANPCategory("cat_Navigation"), DefaultValue(true)]
        public bool ShowPageIndex
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ShowPageIndex;
                object obj = ViewState["ShowPageIndex"];
                return (obj == null) ? true : (bool)obj;
            }
            set { ViewState["ShowPageIndex"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ShowMoreButtons"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_ShowMoreButtons"), ANPCategory("cat_Navigation"), DefaultValue(true)]
        public bool ShowMoreButtons
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ShowMoreButtons;
                object obj = ViewState["ShowMoreButtons"];
                return (obj == null) ? true : (bool)obj;
            }
            set { ViewState["ShowMoreButtons"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="FirstPageText"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_FirstPageText"), ANPCategory("cat_Navigation"), DefaultValue("&lt;&lt;")]
        public string FirstPageText
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.FirstPageText;
                object obj = ViewState["FirstPageText"];
                return (obj == null) ? "&lt;&lt;" : (string)obj;
            }
            set { ViewState["FirstPageText"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PrevPageText"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_PrevPageText"), ANPCategory("cat_Navigation"), DefaultValue("&lt;")]
        public string PrevPageText
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.PrevPageText;
                object obj = ViewState["PrevPageText"];
                return (obj == null) ? "&lt;" : (string)obj;
            }
            set { ViewState["PrevPageText"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="NextPageText"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_NextPageText"), ANPCategory("cat_Navigation"), DefaultValue("&gt;")]
        public string NextPageText
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.NextPageText;
                object obj = ViewState["NextPageText"];
                return (obj == null) ? "&gt;" : (string)obj;
            }
            set { ViewState["NextPageText"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="LastPageText"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_LastPageText"), ANPCategory("cat_Navigation"), DefaultValue("&gt;&gt;")]
        public string LastPageText
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.LastPageText;
                object obj = ViewState["LastPageText"];
                return (obj == null) ? "&gt;&gt;" : (string)obj;
            }
            set { ViewState["LastPageText"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="NumericButtonCount"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_NumericButtonCount"), ANPCategory("cat_Navigation"), DefaultValue(10)]
        public int NumericButtonCount
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.NumericButtonCount;
                object obj = ViewState["NumericButtonCount"];
                return (obj == null) ? 10 : (int)obj;
            }
            set { ViewState["NumericButtonCount"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ShowDisabledButtons"]/*'/>
        [Browsable(true), Themeable(true), ANPCategory("cat_Navigation"), ANPDescription("desc_ShowDisabledButtons"), DefaultValue(true)]
        public bool ShowDisabledButtons
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ShowDisabledButtons;
                object obj = ViewState["ShowDisabledButtons"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                ViewState["ShowDisabledButtons"] = value;
            }
        }

        #endregion

        #region Page item templates

        ///// <include file='AspnetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PagerItemTemplate"]/*'/>
        //[Browsable(true), Themeable(true), DefaultValue(null), ANPCategory("cat_Navigation"), ANPDescription("desc_PagerItemTemplate")]
        //public string PagerItemTemplate
        //{
        //    get
        //    {
        //        if (null != cloneFrom)
        //            return cloneFrom.PagerItemTemplate;
        //        object obj = ViewState["PagerItemTemplate"];
        //        return (obj == null) ? String.Empty : (string)obj;
        //    }
        //    set
        //    {
        //        ViewState["PagerItemTemplate"] = value;
        //    }
        //}

        ///// <include file='AspnetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="NumericPagerItemTemplate"]/*'/>
        //[Browsable(true), Themeable(true), DefaultValue(null), ANPCategory("cat_Navigation"), ANPDescription("desc_NumericPagerItemTemplate")]
        //public string NumericPagerItemTemplate
        //{
        //    get
        //    {
        //        if (null != cloneFrom)
        //            return cloneFrom.NumericPagerItemTemplate;
        //        object obj = ViewState["NumericPagerItemTemplate"];
        //        return (obj == null) ? PagerItemTemplate : (string)obj;
        //    }
        //    set
        //    {
        //        ViewState["NumericPagerItemTemplate"] = value;
        //    }
        //}

        ///// <include file='AspnetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="NavigationPagerItemTemplate"]/*'/>
        //[Browsable(true), Themeable(true), DefaultValue(null), ANPCategory("cat_Navigation"), ANPDescription("desc_NavigationPagerItemTemplate")]
        //public string NavigationPagerItemTemplate
        //{
        //    get
        //    {
        //        if (null != cloneFrom)
        //            return cloneFrom.NavigationPagerItemTemplate;
        //        object obj = ViewState["NavigationPagerItemTemplate"];
        //        return (obj == null) ? PagerItemTemplate : (string)obj;
        //    }
        //    set
        //    {
        //        ViewState["DisabledPagerItemTemplate"] = value;
        //    }
        //}

        ///// <include file='AspnetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="DisabledPagerItemTemplate"]/*'/>
        //[Browsable(true), Themeable(true), DefaultValue(null), ANPCategory("cat_Navigation"), ANPDescription("desc_DisabledPagerItemTemplate")]
        //public string DisabledPagerItemTemplate
        //{
        //    get
        //    {
        //        if (null != cloneFrom)
        //            return cloneFrom.DisabledPagerItemTemplate;
        //        object obj = ViewState["DisabledPagerItemTemplate"];
        //        return (obj == null) ? NavigationPagerItemTemplate : (string)obj;
        //    }
        //    set
        //    {
        //        ViewState["DisabledPagerItemTemplate"] = value;
        //    }
        //}

        ///// <include file='AspnetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CurrentPagerItemTemplate"]/*'/>
        //[Browsable(true), Themeable(true), DefaultValue(null), ANPCategory("cat_Navigation"), ANPDescription("desc_CurrentPagerItemTemplate")]
        //public string CurrentPagerItemTemplate
        //{
        //    get
        //    {
        //        if (null != cloneFrom)
        //            return cloneFrom.CurrentPagerItemTemplate;
        //        object obj = ViewState["CurrentPagerItemTemplate"];
        //        return (obj == null) ? NumericPagerItemTemplate : (string)obj;
        //    }
        //    set
        //    {
        //        ViewState["CurrentPagerItemTemplate"] = value;
        //    }
        //}
        #endregion

        #region Image Navigation Buttons

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ImagePath"]/*'/>
        [Browsable(true), Category("Appearance"), ANPDescription("desc_ImagePath"), DefaultValue(null)]
        public string ImagePath
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ImagePath;
                string imgPath = (string)ViewState["ImagePath"];
                if (imgPath != null)
                    imgPath = ResolveUrl(imgPath);
                return imgPath;
            }
            set
            {
                string imgPath = value.Trim().Replace("\\", "/");
                ViewState["ImagePath"] = (imgPath.EndsWith("/")) ? imgPath : imgPath + "/";
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ButtonImageExtension"]/*'/>
        [Browsable(true), Themeable(true), Category("Appearance"), DefaultValue(".gif"), ANPDescription("desc_ButtonImageExtension")]
        public string ButtonImageExtension
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ButtonImageExtension;
                object obj = ViewState["ButtonImageExtension"];
                return (obj == null) ? ".gif" : (string)obj;
            }
            set
            {
                string ext = value.Trim();
                ViewState["ButtonImageExtension"] = (ext.StartsWith(".")) ? ext : ("." + ext);
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ButtonImageNameExtension"]/*'/>
        [Browsable(true), Themeable(true), DefaultValue(null), Category("Appearance"), ANPDescription("desc_ButtonImageNameExtension")]
        public string ButtonImageNameExtension
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ButtonImageNameExtension;
                object obj = ViewState["ButtonImageNameExtension"];
                return (obj == null) ? null : (string)obj;
            }
            set
            {
                ViewState["ButtonImageNameExtension"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CpiButtonImageNameExtension"]/*'/>
        [Browsable(true), Themeable(true), DefaultValue(null), Category("Appearance"), ANPDescription("desc_CpiButtonImageNameExtension")]
        public string CpiButtonImageNameExtension
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.CpiButtonImageNameExtension;
                object obj = ViewState["CpiButtonImageNameExtension"];
                return (obj == null) ? ButtonImageNameExtension : (string)obj;
            }
            set
            {
                ViewState["CpiButtonImageNameExtension"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="DisabledButtonImageNameExtension"]/*'/>
        [Browsable(true), Themeable(true), DefaultValue(null), Category("Appearance"), ANPDescription("desc_DisabledButtonImageNameExtension")]
        public string DisabledButtonImageNameExtension
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.DisabledButtonImageNameExtension;
                object obj = ViewState["DisabledButtonImageNameExtension"];
                return (obj == null) ? ButtonImageNameExtension : (string)obj;
            }
            set
            {
                ViewState["DisabledButtonImageNameExtension"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ButtonImageAlign"]/*'/>
        [Browsable(true), ANPDescription("desc_ButtonImageAlign"), DefaultValue(ImageAlign.NotSet), Category("Appearance")]
        public ImageAlign ButtonImageAlign
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ButtonImageAlign;
                object obj = ViewState["ButtonImageAlign"];
                return (obj == null) ? ImageAlign.NotSet : (ImageAlign)obj;
            }
            set
            {
                if (value != ImageAlign.Right && value != ImageAlign.Left)
                    ViewState["ButtonImageAlign"] = value;
            }
        }


        #endregion

        #region Paging

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="UrlPaging"]/*'/>
        [Browsable(true), ANPCategory("cat_Paging"), DefaultValue(false), ANPDescription("desc_UrlPaging")]
        public bool UrlPaging
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.UrlPaging;
                object obj = ViewState["UrlPaging"];
                return (null == obj) ? false : (bool)obj;
            }
            set
            {
                ViewState["UrlPaging"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="UrlPageIndexName"]/*'/>
        [Browsable(true), DefaultValue("page"), ANPCategory("cat_Paging"), ANPDescription("desc_UrlPageIndexName")]
        public string UrlPageIndexName
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.UrlPageIndexName;
                object obj = ViewState["UrlPageIndexName"];
                return (null == obj) ? "page" : (string)obj;
            }
            set { ViewState["UrlPageIndexName"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="UrlPageSizeName"]/*'/>
        [Browsable(true), DefaultValue(""), ANPCategory("cat_Paging"), ANPDescription("desc_UrlPageSizeName")]
        public string UrlPageSizeName
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.UrlPageSizeName;
                return (string)ViewState["UrlPageSizeName"];
            }
            set { ViewState["UrlPageSizeName"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ReverseUrlPageIndex"]/*'/>
        [Browsable(true), DefaultValue(false), ANPCategory("cat_Paging"), ANPDescription("desc_ReverseUrlPageIndex")]
        public bool ReverseUrlPageIndex
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ReverseUrlPageIndex;
                object obj = ViewState["ReverseUrlPageIndex"];
                return (null == obj) ? false : (bool)obj;
            }
            set { ViewState["ReverseUrlPageIndex"] = value; }
        }


        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CurrentPageIndex"]/*'/>
        [Browsable(true), ANPDescription("desc_CurrentPageIndex"), ANPCategory("cat_Paging"), DefaultValue(1)]
        public int CurrentPageIndex
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.CurrentPageIndex;
                object cpage = ViewState["CurrentPageIndex"];
                int pindex = (cpage == null) ? 1 : (int)cpage;
                if (pindex > PageCount && PageCount > 0)
                    return PageCount;
                if (pindex < 1)
                    return 1;
                return pindex;
            }
            set
            {
                int cpage = value;
                if (cpage < 1)
                    cpage = 1;
                else if (cpage > PageCount)
                    cpage = PageCount;
                ViewState["CurrentPageIndex"] = cpage;
                //if(!pageChangeEventHandled)
                //{
                //    OnPageChanging(new PageChangingEventArgs(cpage));
                //}
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="RecordCount"]/*'/>
        [Browsable(false), ANPDescription("desc_RecordCount"), Category("Data"), DefaultValue(0)]
        public int RecordCount
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.RecordCount;
                object obj = ViewState["Recordcount"];
                return (obj == null) ? 0 : (int)obj;
            }
            set { ViewState["Recordcount"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PagesRemain"]/*'/>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int PagesRemain
        {
            get
            {
                return PageCount - CurrentPageIndex;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PageSize"]/*'/>
        [Browsable(true), ANPDescription("desc_PageSize"), ANPCategory("cat_Paging"), DefaultValue(10)]
        public int PageSize
        {
            get
            {
                if (!string.IsNullOrEmpty(UrlPageSizeName) && !DesignMode)
                {
                    int pageSize;
                    if (int.TryParse(Page.Request.QueryString[UrlPageSizeName], out pageSize))
                    {
                        if (pageSize > 0)
                            return pageSize;
                    }
                }
                if (null != cloneFrom)
                    return cloneFrom.PageSize;
                object obj = ViewState["PageSize"];
                return (obj == null) ? 10 : (int)obj;
            }
            set
            {
                ViewState["PageSize"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="RecordsRemain"]/*'/>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int RecordsRemain
        {
            get
            {
                if (CurrentPageIndex < PageCount)
                    return RecordCount - (CurrentPageIndex * PageSize);
                return 0;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="StartRecordIndex"]/*'/>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int StartRecordIndex
        {
            get
            {
                //if (FillLastPage && RecordCount > PageSize && CurrentPageIndex == PageCount)
                //    return RecordCount - PageSize;
                return (CurrentPageIndex - 1) * PageSize + 1;
            }
        }


        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="EndRecordIndex"]/*'/>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EndRecordIndex
        {
            get
            {
                return RecordCount - RecordsRemain;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PageCount"]/*'/>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int PageCount
        {
            get
            {
                if (RecordCount == 0)
                    return 1;
                return (int)Math.Ceiling((double)RecordCount / (double)PageSize);
            }
        }


        #endregion

        #region Page index box


        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ShowPageIndexBox"]/*'/>
        [Browsable(true), ANPCategory("cat_PageIndexBox"), DefaultValue(ShowPageIndexBox.Auto), ANPDescription("desc_ShowPageIndexBox")]
        public ShowPageIndexBox ShowPageIndexBox
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ShowPageIndexBox;
                object obj = ViewState["ShowPageIndexBox"];
                return (obj == null) ? ShowPageIndexBox.Auto : (ShowPageIndexBox)obj;
            }
            set { ViewState["ShowPageIndexBox"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PageIndexBoxType"]/*'/>
        [Browsable(true), ANPCategory("cat_PageIndexBox"), DefaultValue(PageIndexBoxType.TextBox), ANPDescription("desc_PageIndexBoxType")]
        public PageIndexBoxType PageIndexBoxType
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.PageIndexBoxType;
                object obj = ViewState["PageIndexBoxType"];
                return (obj == null) ? PageIndexBoxType.TextBox : (PageIndexBoxType)obj;
            }
            set
            {
                ViewState["PageIndexBoxType"] = value;
            }
        }


        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PageIndexBoxClass"]/*'/>
        [Browsable(true), ANPCategory("cat_PageIndexBox"), DefaultValue(null), ANPDescription("desc_PageIndexBoxClass")]
        public string PageIndexBoxClass
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.PageIndexBoxClass;
                object obj = ViewState["PageIndexBoxClass"];
                return (obj == null) ? null : (string)obj;
            }
            set
            {
                if (value.Trim().Length > 0)
                    ViewState["PageIndexBoxClass"] = value;
            }
        }


        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PageIndexBoxStyle"]/*'/>
        [Browsable(true), ANPCategory("cat_PageIndexBox"), DefaultValue(null), ANPDescription("desc_PageIndexBoxStyle")]
        public string PageIndexBoxStyle
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.PageIndexBoxStyle;
                object obj = ViewState["PageIndexBoxStyle"];
                return (obj == null) ? null : (string)obj;
            }
            set
            {
                if (value.Trim().Length > 0)
                    ViewState["PageIndexBoxStyle"] = value;
            }
        }


        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="TextBeforePageIndexBox"]/*'/>
        [Browsable(true), Themeable(true), ANPCategory("cat_PageIndexBox"), DefaultValue(null), ANPDescription("desc_TextBeforePageIndexBox")]
        public string TextBeforePageIndexBox
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.TextBeforePageIndexBox;
                object obj = ViewState["TextBeforePageIndexBox"];
                return (null == obj) ? null : (string)obj;
            }
            set
            {
                ViewState["TextBeforePageIndexBox"] = value;
            }
        }


        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="TextAfterPageIndexBox"]/*'/>
        [Browsable(true), Themeable(true), DefaultValue(null), ANPCategory("cat_PageIndexBox"), ANPDescription("desc_TextAfterPageIndexBox")]
        public string TextAfterPageIndexBox
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.TextAfterPageIndexBox;
                object obj = ViewState["TextAfterPageIndexBox"];
                return (null == obj) ? null : (string)obj;
            }
            set
            {
                ViewState["TextAfterPageIndexBox"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="SubmitButtonText"]/*'/>
        [Browsable(true), Themeable(true), ANPCategory("cat_PageIndexBox"), DefaultValue("go"), ANPDescription("desc_SubmitButtonText")]
        public string SubmitButtonText
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.SubmitButtonText;
                object obj = ViewState["SubmitButtonText"];
                return (null == obj) ? "go" : (string)obj;
            }
            set
            {
                if (null == value)
                    value = "go";
                ViewState["SubmitButtonText"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="SubmitButtonClass"]/*'/>
        [Browsable(true), ANPCategory("cat_PageIndexBox"), DefaultValue(null), ANPDescription("desc_SubmitButtonClass")]
        public string SubmitButtonClass
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.SubmitButtonClass;
                return (string)ViewState["SubmitButtonClass"];
            }
            set
            {
                ViewState["SubmitButtonClass"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="SubmitButtonStyle"]/*'/>
        [Browsable(true), ANPCategory("cat_PageIndexBox"), DefaultValue(null), ANPDescription("desc_SubmitButtonStyle")]
        public string SubmitButtonStyle
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.SubmitButtonStyle;
                return (string)ViewState["SubmitButtonStyle"];
            }
            set
            {
                ViewState["SubmitButtonStyle"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="SubmitButtonImageUrl"]/*'/>
        [Browsable(true), DefaultValue(""), Category("Appearance"), ANPDescription("desc_SubmitButtonImageUrl")]
        public string SubmitButtonImageUrl
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.SubmitButtonImageUrl;
                return (string)ViewState["SubmitButtonImageUrl"];
            }
            set { ViewState["SubmitButtonImageUrl"] = value; }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ShowBoxThreshold"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_ShowBoxThreshold"), ANPCategory("cat_PageIndexBox"), DefaultValue(30)]
        public int ShowBoxThreshold
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ShowBoxThreshold;
                object obj = ViewState["ShowBoxThreshold"];
                return (null == obj) ? 30 : (int)obj;
            }
            set { ViewState["ShowBoxThreshold"] = value; }
        }


        #endregion

        #region CustomInfoSection

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="ShowCustomInfoSection"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_ShowCustomInfoSection"), DefaultValue(ShowCustomInfoSection.Never), Category("Appearance")]
        public ShowCustomInfoSection ShowCustomInfoSection
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.ShowCustomInfoSection;
                object obj = ViewState["ShowCustomInfoSection"];
                return (null == obj) ? ShowCustomInfoSection.Never : (ShowCustomInfoSection)obj;
            }
            set
            {
                if (LayoutType == LayoutType.Ul && value != ShowCustomInfoSection.Never)
                {
                    throw new NotSupportedException("Can not show custom info section if LayoutType is set to Ul!");
                }
                ViewState["ShowCustomInfoSection"] = value;
            }
        }


        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CustomInfoTextAlign"]/*'/>
        [Browsable(true), Category("Appearance"), DefaultValue(HorizontalAlign.NotSet), ANPDescription("desc_CustomInfoTextAlign")]
        public HorizontalAlign CustomInfoTextAlign
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.CustomInfoTextAlign;
                object obj = ViewState["CustomInfoTextAlign"];
                return (null == obj) ? HorizontalAlign.NotSet : (HorizontalAlign)obj;
            }
            set
            {
                ViewState["CustomInfoTextAlign"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CustomInfoSectionWidth"]/*'/>
        [Browsable(true), Category("Appearance"), DefaultValue(typeof(Unit), "40%"), ANPDescription("desc_CustomInfoSectionWidth")]
        public Unit CustomInfoSectionWidth
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.CustomInfoSectionWidth;
                object obj = ViewState["CustomInfoSectionWidth"];
                return (null == obj) ? Unit.Percentage(40) : (Unit)obj;
            }
            set
            {
                ViewState["CustomInfoSectionWidth"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CustomInfoClass"]/*'/>
        [Browsable(true), Category("Appearance"), DefaultValue(null), ANPDescription("desc_CustomInfoClass")]
        public string CustomInfoClass
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.CustomInfoClass;
                object obj = ViewState["CustomInfoClass"];
                return (null == obj) ? CssClass : (string)obj;
            }
            set
            {
                ViewState["CustomInfoClass"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CustomInfoStyle"]/*'/>
        [Browsable(true), Category("Appearance"), DefaultValue(null), ANPDescription("desc_CustomInfoStyle")]
        public string CustomInfoStyle
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.CustomInfoStyle;
                object obj = ViewState["CustomInfoStyle"];
                return (null == obj) ? Style.Value : (string)obj;
            }
            set
            {
                ViewState["CustomInfoStyle"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CustomInfoHTML"]/*'/>
        [Browsable(true), Themeable(true), Category("Appearance"), DefaultValue("Page %CurrentPageIndex% of %PageCount%"), ANPDescription("desc_CustomInfoHTML")]
        public string CustomInfoHTML
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.CustomInfoHTML;
                object obj = ViewState["CustomInfoText"];
                return (null == obj) ? "Page %CurrentPageIndex% of %PageCount%" : (string)obj;
            }
            set
            {
                ViewState["CustomInfoText"] = value;
            }
        }

        #endregion

        #region Css class and styles


        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CurrentPageButtonStyle"]/*'/>
        [Browsable(true), Category("Appearance"), ANPDescription("desc_CurrentPageButtonStyle"), DefaultValue(null)]
        public string CurrentPageButtonStyle
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.CurrentPageButtonStyle;
                object obj = ViewState["CPBStyle"];
                return (null == obj) ? null : (string)obj;
            }
            set
            {
                ViewState["CPBStyle"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CurrentPageButtonClass"]/*'/>
        [Browsable(true), Category("Appearance"), ANPDescription("desc_CurrentPageButtonClass"), DefaultValue(null)]
        public string CurrentPageButtonClass
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.CurrentPageButtonClass;
                object obj = ViewState["CPBClass"];
                return (null == obj) ? null : (string)obj;
            }
            set
            {
                ViewState["CPBClass"] = value;
            }
        }


        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PagingButtonsClass"]/*'/>
        [Browsable(true), Category("Appearance"), Themeable(true), ANPDescription("desc_PagingButtonsClass"), DefaultValue(null)]
        public string PagingButtonsClass
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.PagingButtonsClass;
                object obj = ViewState["PagingButtonsClass"];
                return (null == obj) ? null : (string)obj;
            }
            set
            {
                ViewState["PagingButtonsClass"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PagingButtonsStyle"]/*'/>
        [Browsable(true), Category("Appearance"), Themeable(true), ANPDescription("desc_PagingButtonsStyle"), DefaultValue(null)]
        public string PagingButtonsStyle
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.PagingButtonsStyle;
                object obj = ViewState["PagingButtonsStyle"];
                return (null == obj) ? null : (string)obj;
            }
            set
            {
                ViewState["PagingButtonsStyle"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="FirstLastButtonsClass"]/*'/>
        [Browsable(true), Category("Appearance"), Themeable(true), ANPDescription("desc_FirstLastButtonsClass"), DefaultValue(null)]
        public string FirstLastButtonsClass
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.FirstLastButtonsClass;
                object obj = ViewState["FirstLastButtonsClass"];
                return (null == obj) ? PagingButtonsClass : (string)obj;
            }
            set
            {
                ViewState["FirstLastButtonsClass"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="FirstLastButtonsStyle"]/*'/>
        [Browsable(true), Category("Appearance"), Themeable(true), ANPDescription("desc_FirstLastButtonsStyle"), DefaultValue(null)]
        public string FirstLastButtonsStyle
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.FirstLastButtonsStyle;
                object obj = ViewState["FirstLastButtonsStyle"];
                return (null == obj) ? PagingButtonsStyle : (string)obj;
            }
            set
            {
                ViewState["FirstLastButtonsStyle"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PrevNextButtonsClass"]/*'/>
        [Browsable(true), Category("Appearance"), Themeable(true), ANPDescription("desc_PrevNextButtonsClass"), DefaultValue(null)]
        public string PrevNextButtonsClass
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.PrevNextButtonsClass;
                object obj = ViewState["PrevNextButtonsClass"];
                return (null == obj) ? PagingButtonsClass : (string)obj;
            }
            set
            {
                ViewState["PrevNextButtonsClass"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PrevNextButtonsStyle"]/*'/>
        [Browsable(true), Category("Appearance"), Themeable(true), ANPDescription("desc_PrevNextButtonsStyle"), DefaultValue(null)]
        public string PrevNextButtonsStyle
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.PrevNextButtonsStyle;
                object obj = ViewState["PrevNextButtonsStyle"];
                return (null == obj) ? PagingButtonsStyle : (string)obj;
            }
            set
            {
                ViewState["PrevNextButtonsStyle"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="MoreButtonsClass"]/*'/>
        [Browsable(true), Category("Appearance"), Themeable(true), ANPDescription("desc_MoreButtonsClass"), DefaultValue(null)]
        public string MoreButtonsClass
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.MoreButtonsClass;
                object obj = ViewState["MoreButtonsClass"];
                return (null == obj) ? PagingButtonsClass : (string)obj;
            }
            set
            {
                ViewState["MoreButtonsClass"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="MoreButtonsStyle"]/*'/>
        [Browsable(true), Category("Appearance"), Themeable(true), ANPDescription("desc_MoreButtonsStyle"), DefaultValue(null)]
        public string MoreButtonsStyle
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.MoreButtonsStyle;
                object obj = ViewState["MoreButtonsStyle"];
                return (null == obj) ? PagingButtonsStyle : (string)obj;
            }
            set
            {
                ViewState["MoreButtonsStyle"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="HorizontalAlign"]/*'/>
        [Browsable(true), Category("Appearance"), DefaultValue(HorizontalAlign.NotSet), ANPDescription("desc_HorizontalAlign")]
        public HorizontalAlign HorizontalAlign
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.HorizontalAlign;
                object obj = ViewState["HorizontalAlign"];
                return (null == obj) ? HorizontalAlign.NotSet : (HorizontalAlign)obj;
            }
            set
            {
                ViewState["HorizontalAlign"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="BackImageUrl"]/*'/>
        [Browsable(true), Category("Appearance"), Themeable(true), ANPDescription("desc_BackImageUrl"), DefaultValue(null)]
        public string BackImageUrl
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.BackImageUrl;
                object obj = ViewState["BackImageUrl"];
                return (null == obj) ? null : (string)obj;
            }
            set
            {
                ViewState["BackImageUrl"] = value;
            }
        }
        /*
        public string DisabledButtonsClass
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.DisabledButtonsClass;
                object obj = ViewState["DisabledButtonsClass"];
                return (null == obj) ? DisabledButtonsClass : (string)obj;
            }
            set
            {
                ViewState["DisabledButtonsClass"] = value;
            }
        }


        public string DisabledButtonsStyle
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.DisabledButtonsStyle;
                object obj = ViewState["DisabledButtonsStyle"];
                return (null == obj) ? DisabledButtonsStyle : (string)obj;
            }
            set
            {
                ViewState["DisabledButtonsStyle"] = value;
            }
        }
         */
        #endregion

        #region Others

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="CloneFrom"]/*'/>
        [Browsable(true), Themeable(false), TypeConverter(typeof(AspNetPagerIDConverter)), Category("Behavior"), DefaultValue(false), ANPDescription("desc_CloneFrom")]
        public string CloneFrom
        {
            get
            {
                return (string)ViewState["CloneFrom"];
            }
            set
            {
                if (null != value && String.Empty == value.Trim())
                    throw new ArgumentNullException("CloneFrom", SR.GetString("def_EmptyCloneFrom"));
                if (ID.Equals(value, StringComparison.OrdinalIgnoreCase))
                    throw new ArgumentException(SR.GetString("def_RecursiveCloneFrom"), "CloneFrom");
                ViewState["CloneFrom"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="EnableTheming"]/*'/>
        public override bool EnableTheming
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.EnableTheming;
                return base.EnableTheming;
            }
            set
            {
                base.EnableTheming = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="SkinID"]/*'/>
        public override string SkinID
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.SkinID;
                return base.SkinID;
            }
            set
            {
                base.SkinID = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="EnableUrlRewriting"]/*'/>
        [Browsable(true), Themeable(true), Category("Behavior"), DefaultValue(false), ANPDescription("desc_EnableUrlWriting")]
        public bool EnableUrlRewriting
        {
            get
            {
                object obj = ViewState["UrlRewriting"];
                if (null == obj)
                {
                    if (null != cloneFrom)
                        return cloneFrom.EnableUrlRewriting;
                    return false;
                }
                return (bool)obj;
            }
            set
            {
                ViewState["UrlRewriting"] = value;
                if (value)
                    UrlPaging = true;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="UrlRewritePattern"]/*'/>
        [Browsable(true), Themeable(true), Category("Behavior"), DefaultValue(null), ANPDescription("desc_UrlRewritePattern")]
        public string UrlRewritePattern
        {
            get
            {
                object obj = ViewState["URPattern"];
                if (null == obj)
                {
                    if (null != cloneFrom)
                        return cloneFrom.UrlRewritePattern;
                    if (EnableUrlRewriting)
                    {
                        if (!DesignMode)
                        {
                            string filePath = Page.Request.FilePath;
                            return Path.GetFileNameWithoutExtension(filePath) + "_{0}" + Path.GetExtension(filePath);
                        }
                    }
                    return null;
                }
                return (string)obj;
            }
            set
            {
                ViewState["URPattern"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="FirstPageUrlRewritePattern"]/*'/> added on 2012-11-11
        [Browsable(true), Themeable(true), Category("Behavior"), DefaultValue(null), ANPDescription("desc_FirstPageUrlRewritePattern")]
        public string FirstPageUrlRewritePattern
        {
            get
            {
                object obj = ViewState["FPURPattern"];
                if (null == obj)
                {
                    if (null != cloneFrom)
                        return cloneFrom.FirstPageUrlRewritePattern;
                    return UrlRewritePattern;
                }
                return (string)obj;
            }
            set
            {
                ViewState["FPURPattern"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="AlwaysShow"]/*'/>
        [Browsable(true), Themeable(true), Category("Behavior"), DefaultValue(false), ANPDescription("desc_AlwaysShow")]
        public bool AlwaysShow
        {
            get
            {
                object obj = ViewState["AlwaysShow"];
                if (null == obj)
                {
                    if (null != cloneFrom)
                        return cloneFrom.AlwaysShow;
                    return false;
                }
                return (bool)obj;
            }
            set
            {
                ViewState["AlwaysShow"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="AlwaysShowFirstLastPageNumber"]/*'/>
        [Browsable(true), Themeable(true), Category("Behavior"), DefaultValue(false), ANPDescription("desc_AlwaysShowFirstLastPageNumber")]
        public bool AlwaysShowFirstLastPageNumber
        {
            get
            {
                object obj = ViewState["AlwaysShowFirstLastPageNumber"];
                if (null == obj)
                {
                    if (null != cloneFrom)
                        return cloneFrom.AlwaysShowFirstLastPageNumber;
                    return false;
                }
                return (bool)obj;
            }
            set
            {
                ViewState["AlwaysShowFirstLastPageNumber"] = value;
            }
        }
        
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="PageIndexOutOfRangeErrorMessage"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_PIOutOfRangeMsg"), ANPDefaultValue("def_PIOutOfRangeMsg"), Category("Data")]
        public string PageIndexOutOfRangeErrorMessage
        {
            get
            {
                object obj = ViewState["PIOutOfRangeErrorMsg"];
                if (null == obj)
                {
                    if (null != cloneFrom)
                        return cloneFrom.PageIndexOutOfRangeErrorMessage;
                    return SR.GetString("def_PIOutOfRangeMsg");
                }
                return (string)obj;
            }
            set
            {
                ViewState["PIOutOfRangeErrorMsg"] = value;
            }
        }

        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="InvalidPageIndexErrorMessage"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_InvalidPIErrorMsg"), ANPDefaultValue("def_InvalidPIErrorMsg"), Category("Data")]
        public string InvalidPageIndexErrorMessage
        {
            get
            {
                object obj = ViewState["InvalidPIErrorMsg"];
                if (null == obj)
                {
                    if (null != cloneFrom)
                        return cloneFrom.InvalidPageIndexErrorMessage;
                    return SR.GetString("def_InvalidPIErrorMsg");
                }
                return (string)obj;
            }
            set
            {
                ViewState["InvalidPIErrorMsg"] = value;
            }
        }


        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Property[@name="LayoutType"]/*'/>
        [Browsable(true), Themeable(true), ANPDescription("desc_LayoutType"), ANPDefaultValue("Div"), Category("Appearance")]
        public LayoutType LayoutType
        {
            get
            {
                if (null != cloneFrom)
                    return cloneFrom.LayoutType;
                object obj = ViewState["LayoutType"];
                return (null == obj) ? LayoutType.Div : (LayoutType)obj;
            }
            set { ViewState["LayoutType"] = value; }
        }

        #endregion
    }
}
