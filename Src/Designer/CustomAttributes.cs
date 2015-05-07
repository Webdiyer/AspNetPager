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
using System.Resources;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wuqi.Webdiyer
{
    #region Custom Attributes

    [AttributeUsage(AttributeTargets.All)]
    internal sealed class ANPDescriptionAttribute : DescriptionAttribute
    {
        public ANPDescriptionAttribute(string text)  : base(text)
        {
            replaced = false;
        }

        public override string Description
        {
            get
            {
                if (!replaced)
                {
                    replaced = true;
                    DescriptionValue = SR.GetString(DescriptionValue);
                }
                return base.Description;
            }
        }
        private bool replaced;
    }

    [AttributeUsage(AttributeTargets.All)]
    internal class ANPCategoryAttribute : CategoryAttribute
    {
        internal ANPCategoryAttribute(string name) : base(name) { }

        protected override string GetLocalizedString(string value)
        {
            string cat = base.GetLocalizedString(value);
            if (null == cat)
                cat = SR.GetString(value);
            return cat;
        }
    }


    [AttributeUsage(AttributeTargets.All)]
    internal class ANPDefaultValueAttribute : DefaultValueAttribute
    {
        public ANPDefaultValueAttribute(string name)
            : base(name)
        {
            localized = false;
        }

        public override object Value
        {
            get
            {
                if (!localized)
                {
                    localized = true;
                    string defValue = (string)base.Value;
                    if (!string.IsNullOrEmpty(defValue))
                    {
                        return SR.GetString(defValue);
                    }
                }
                return base.Value;
            }
        }
        private bool localized;
    }

    internal sealed class SR
    {
        private SR()
        {
            _rm = new ResourceManager("Wuqi.Webdiyer.AspNetPager", GetType().Assembly);
        }

        private ResourceManager Resources
        {
            get { return _rm; }
        }

        private ResourceManager _rm;


        private static SR GetLoader()
        {
            if (null == _loader)
            {
                lock (_lock)
                {
                    if (null == _loader)
                        _loader = new SR();
                }
            }
            return _loader;
        }

        public static string GetString(string name)
        {
            SR loader = GetLoader();
            string localized = null;
            if (null != loader)
                localized = loader.Resources.GetString(name, null);
            return localized??string.Empty;
        }

        private static SR _loader = null;

        private static object _lock = new object();
    }

    /// <summary>
    /// AspNetPager type converter used for the design time support
    /// </summary>
    internal class AspNetPagerIDConverter : ControlIDConverter
    {
        protected override bool FilterControl(Control control)
        {
            if (control is AspNetPager)
                return true;
            return false;
        }
    }
    #endregion
}
