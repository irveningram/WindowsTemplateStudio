﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Templates.UI.Controls
{
    public sealed partial class TogglePane
    {
        #region TogglePaneContent
        public object TogglePaneContent
        {
            get { return GetValue(TogglePaneContentProperty); }
            set { SetValue(TogglePaneContentProperty, value); }
        }
        public static readonly DependencyProperty TogglePaneContentProperty = DependencyProperty.Register("TogglePaneContent", typeof(object), typeof(TogglePane), new PropertyMetadata(null));
        #endregion

        #region MainViewTemplate
        public DataTemplate MainViewTemplate
        {
            get { return (DataTemplate)GetValue(MainViewTemplateProperty); }
            set { SetValue(MainViewTemplateProperty, value); }
        }
        public static readonly DependencyProperty MainViewTemplateProperty = DependencyProperty.Register("MainViewTemplate", typeof(DataTemplate), typeof(TogglePane), new PropertyMetadata(null));
        #endregion

        #region MainViewTemplateSelector
        public DataTemplateSelector MainViewTemplateSelector
        {
            get { return (DataTemplateSelector)GetValue(MainViewTemplateSelectorProperty); }
            set { SetValue(MainViewTemplateSelectorProperty, value); }
        }
        public static readonly DependencyProperty MainViewTemplateSelectorProperty = DependencyProperty.Register("MainViewTemplateSelector", typeof(DataTemplateSelector), typeof(TogglePane), new PropertyMetadata(null));
        #endregion

        #region SecondaryViewTemplate
        public DataTemplate SecondaryViewTemplate
        {
            get { return (DataTemplate)GetValue(SecondaryViewTemplateProperty); }
            set { SetValue(SecondaryViewTemplateProperty, value); }
        }
        public static readonly DependencyProperty SecondaryViewTemplateProperty = DependencyProperty.Register("SecondaryViewTemplate", typeof(DataTemplate), typeof(TogglePane), new PropertyMetadata(null));
        #endregion

        #region OpenButtonTemplate
        public DataTemplate OpenButtonTemplate
        {
            get { return (DataTemplate)GetValue(OpenButtonTemplateProperty); }
            set { SetValue(OpenButtonTemplateProperty, value); }
        }
        public static readonly DependencyProperty OpenButtonTemplateProperty = DependencyProperty.Register("OpenButtonTemplate", typeof(DataTemplate), typeof(TogglePane), new PropertyMetadata(null));
        #endregion

        #region CloseButtonTemplate
        public DataTemplate CloseButtonTemplate
        {
            get { return (DataTemplate)GetValue(CloseButtonTemplateProperty); }
            set { SetValue(CloseButtonTemplateProperty, value); }
        }
        public static readonly DependencyProperty CloseButtonTemplateProperty = DependencyProperty.Register("CloseButtonTemplate", typeof(DataTemplate), typeof(TogglePane), new PropertyMetadata(null));
        #endregion

        #region IsOpen
        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty IsOpenProperty = DependencyProperty.Register("IsOpen", typeof(bool), typeof(TogglePane), new PropertyMetadata(false, OnIsOpenPropertyChanged));

        private static void OnIsOpenPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as TogglePane;
            if (control != null)
            {
                control.UpdateOpenStatus((bool)e.NewValue, (bool)e.OldValue);
            }
        }
        #endregion

        #region AllowDragAndDrop
        public bool AllowDragAndDrop
        {
            get { return (bool)GetValue(AllowDragAndDropProperty); }
            set { SetValue(AllowDragAndDropProperty, value); }
        }

        public static readonly DependencyProperty AllowDragAndDropProperty = DependencyProperty.Register("AllowDragAndDrop", typeof(bool), typeof(TogglePane), new PropertyMetadata(false));
        #endregion
    }
}