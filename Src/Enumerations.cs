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
