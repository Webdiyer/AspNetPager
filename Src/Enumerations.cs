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

namespace Wuqi.Webdiyer
{
    #region Enumerations


    /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Enum[@name="ShowPageIndexBox"]/*'/>
    public enum ShowPageIndexBox : byte
    {
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Never"]/*'/>
        Never,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Auto"]/*'/>
        Auto,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Always"]/*'/>
        Always
    }

    /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Enum[@name="PageIndexBoxType"]/*'/>
    public enum PageIndexBoxType
    {
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="TextBox"]/*'/>
        TextBox,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="DropDownList"]/*'/>
        DropDownList
    }


    /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Enum[@name="ShowCustomInfoSection"]/*'/>
    public enum ShowCustomInfoSection : byte
    {
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="CNever"]/*'/>
        Never,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Left"]/*'/>
        Left,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Right"]/*'/>
        Right
    }

    /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Enum[@name="PagingButtonType"]/*'/>
    public enum PagingButtonType : byte
    {
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Text"]/*'/>
        Text,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Image"]/*'/>
        Image
    }


    /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Enum[@name="LayoutType"]/*'/>
    public enum LayoutType:byte
    {
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Table"]/*'/>
        Table,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Div"]/*'/>
        Div
    }

    /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Enum[@name="PagingButtonPosition"]/*'/>
    public enum PagingButtonPosition:byte
    {
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Beginning"]/*'/>
        Beginning,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="End"]/*'/>
        End,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Center"]/*'/>
        Center,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Fixed"]/*'/>
        Fixed
    }

    /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/Enum[@name="PagingButtonLayoutType"]/*'/>
    public enum PagingButtonLayoutType:byte
    {
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="UnorderedList"]/*'/>
        UnorderedList,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="Span"]/*'/>
        Span,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="None"]/*'/>
        None
    }

    public enum NavigationButtonPosition:byte
    {
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="PLeft"]/*'/>
        Left,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="PRight"]/*'/>
        Right,
        /// <include file='AspNetPagerDocs.xml' path='AspNetPagerDoc/EnumValue[@name="BothSides"]/*'/>
        BothSides
    }
    #endregion
}
