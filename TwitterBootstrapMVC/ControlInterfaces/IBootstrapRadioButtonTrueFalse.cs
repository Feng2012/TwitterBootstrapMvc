﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;

namespace TwitterBootstrapMVC.ControlInterfaces
{
    public interface IBootstrapRadioButtonTrueFalse : IHtmlString
    {
        IBootstrapRadioButtonTrueFalse InputsValues(object trueValue, object falseValue);
        IBootstrapRadioButtonTrueFalse HtmlAttributesInputTrue(object htmlAttributes);
        IBootstrapRadioButtonTrueFalse HtmlAttributesInputFalse(object htmlAttributes);
        IBootstrapRadioButtonTrueFalse HtmlAttributesLabelTrue(object htmlAttributes);
        IBootstrapRadioButtonTrueFalse HtmlAttributesLabelFalse(object htmlAttributes);
        IBootstrapRadioButtonTrueFalse InputLabelsText(string trueText, string falseText);
        IBootstrapRadioButtonTrueFalse Tooltip(TooltipConfiguration configuration);
        IBootstrapRadioButtonTrueFalse Tooltip(string text);
        IBootstrapRadioButtonTrueFalse HelpText(string text, HelpTextStyle style);
        IBootstrapRadioButtonTrueFalse ShowValidationMessage(bool displayValidationMessage);
        IBootstrapRadioButtonTrueFalse ShowValidationMessage(bool displayValidationMessage, HelpTextStyle validationMessageStyle);
        IBootstrapLabel Label();

        [EditorBrowsable(EditorBrowsableState.Never)]
        Type GetType();

        [EditorBrowsable(EditorBrowsableState.Never)]
        int GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        string ToString();

        [EditorBrowsable(EditorBrowsableState.Never)]
        new string ToHtmlString();

        [EditorBrowsable(EditorBrowsableState.Never)]
        bool Equals(object obj);
    }
}
