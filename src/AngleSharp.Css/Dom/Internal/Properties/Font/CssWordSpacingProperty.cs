﻿namespace AngleSharp.Css.Dom
{
    using AngleSharp.Css;
    using AngleSharp.Css.Converters;
    using static ValueConverters;

    /// <summary>
    /// Information:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/word-spacing
    /// Gets if normal inter-word space, as defined by the current font
    /// and/or the browser, is active.
    /// Gets the defined custom spacing, if any.
    /// </summary>
    sealed class CssWordSpacingProperty : CssProperty
    {
        #region Fields

        private static readonly IValueConverter StyleConverter = Or(OptionalLengthConverter, Initial);

        #endregion

        #region ctor

        internal CssWordSpacingProperty()
            : base(PropertyNames.WordSpacing, PropertyFlags.Inherited | PropertyFlags.Unitless | PropertyFlags.Animatable)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            get { return StyleConverter; }
        }

        #endregion
    }
}