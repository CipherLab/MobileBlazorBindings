﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace Blaxamarin.Framework.Elements
{
    public static partial class AttributeHelper
    {
        /// <summary>
        /// Helper method to serialize <see cref="Thickness" /> objects.
        /// </summary>
        public static string ThicknessToString(Thickness thickness)
        {
            return string.Format(
                CultureInfo.InvariantCulture,
                "{0},{1},{2},{3}",
                thickness.Left,
                thickness.Top,
                thickness.Right,
                thickness.Bottom);
        }

        /// <summary>
        /// Helper method to deserialize <see cref="Thickness" /> objects.
        /// </summary>
        public static Thickness StringToThickness(object thicknessString)
        {
            if (thicknessString is null)
            {
                throw new ArgumentNullException(nameof(thicknessString));
            }
            if (!(thicknessString is string thicknessAsString))
            {
                throw new ArgumentNullException(nameof(thicknessString));
            }

            var marginStringParts = thicknessAsString.Split(',');

            return new Thickness(
                left: StringToDouble(marginStringParts[0]),
                top: StringToDouble(marginStringParts[1]),
                right: StringToDouble(marginStringParts[2]),
                bottom: StringToDouble(marginStringParts[3]));
        }
    }
}