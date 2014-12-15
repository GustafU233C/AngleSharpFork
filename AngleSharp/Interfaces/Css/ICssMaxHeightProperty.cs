﻿namespace AngleSharp.DOM.Css
{
    /// <summary>
    /// Represents the CSS max-height property.
    /// </summary>
    public interface ICssMaxHeightProperty : ICssProperty
    {
        /// <summary>
        /// Gets the specified max-height of the element, if any.
        /// </summary>
        Length? Limit { get; }
    }
}
