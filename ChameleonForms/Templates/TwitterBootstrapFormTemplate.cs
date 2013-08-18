﻿using System.Web;
using System.Web.Mvc;
using ChameleonForms.Component.Config;
using ChameleonForms.Enums;

namespace ChameleonForms.Templates
{
    /// <summary>
    /// The default Chameleon Forms form template renderer.
    /// </summary>
    public class TwitterBootstrapFormTemplate : IFormTemplate
    {
        public virtual IHtmlString BeginForm(string action, FormMethod method, HtmlAttributes htmlAttributes, EncType? enctype)
        {
            return HtmlCreator.BuildFormTag(action, method, htmlAttributes, enctype);
        }

        public virtual IHtmlString EndForm()
        {
            return TwitterBootstrapHtmlHelpers.EndForm();
        }

        public virtual IHtmlString BeginSection(IHtmlString title, IHtmlString leadingHtml, HtmlAttributes htmlAttributes)
        {
            return TwitterBootstrapHtmlHelpers.BeginSection(title, leadingHtml, htmlAttributes);
        }

        public virtual IHtmlString EndSection()
        {
            return TwitterBootstrapHtmlHelpers.EndSection();
        }

        public virtual IHtmlString BeginNestedSection(IHtmlString title, IHtmlString leadingHtml, HtmlAttributes htmlAttributes)
        {
            return TwitterBootstrapHtmlHelpers.BeginNestedSection(title, leadingHtml, htmlAttributes);
        }

        public virtual IHtmlString EndNestedSection()
        {
            return TwitterBootstrapHtmlHelpers.EndNestedSection();
        }

        public virtual IHtmlString Field(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration, bool isValid)
        {
            return TwitterBootstrapHtmlHelpers.Field(labelHtml, elementHtml, validationHtml, fieldMetadata, fieldConfiguration);
        }

        public virtual IHtmlString BeginField(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration, bool isValid)
        {
            return TwitterBootstrapHtmlHelpers.BeginField(labelHtml, elementHtml, validationHtml, fieldMetadata, fieldConfiguration);
        }

        public virtual IHtmlString EndField()
        {
            return TwitterBootstrapHtmlHelpers.EndField();
        }

        public virtual IHtmlString BeginMessage(MessageType messageType, IHtmlString heading)
        {
            return TwitterBootstrapHtmlHelpers.BeginMessage(messageType, heading);
        }

        public virtual IHtmlString EndMessage()
        {
            return TwitterBootstrapHtmlHelpers.EndMessage();
        }

        public virtual IHtmlString MessageParagraph(IHtmlString paragraph)
        {
            return TwitterBootstrapHtmlHelpers.MessageParagraph(paragraph);
        }

        public virtual IHtmlString BeginNavigation()
        {
            return TwitterBootstrapHtmlHelpers.BeginNavigation();
        }

        public virtual IHtmlString EndNavigation()
        {
            return TwitterBootstrapHtmlHelpers.EndNavigation();
        }
    }
}