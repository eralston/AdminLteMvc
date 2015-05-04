using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLte
{
    /// <summary>
    /// A class for utility functions and methods in AdminLTE, especially around CSHTMLs
    /// Include functinality such as transforming colors into Admin LTE (or Bootstrap) compatible css classes
    /// NOTE: This isn't in a namespace to it's automatically available in CSHTML files
    /// </summary>
    public class AdminLte
    {
        /// <summary>
        /// List of colors available for background and text elements in Admin LTE
        /// https://almsaeedstudio.com/themes/AdminLTE/pages/UI/general.html
        /// </summary>
        public enum Color
        {
            /// <summary>
            /// bg-light-blue
            /// </summary>
            [Display(Name = "Light Blue")]
            LightBlue,

            /// <summary>
            /// bg-aqua
            /// </summary>
            Aqua,

            /// <summary>
            /// bg-blue
            /// </summary>
            Blue,

            /// <summary>
            /// bg-green
            /// </summary>
            Green,

            /// <summary>
            /// bg-yellow
            /// </summary>
            Yellow,

            /// <summary>
            /// bg-red
            /// </summary>
            Red,

            /// <summary>
            /// bg-gray
            /// </summary>
            Gray,

            /// <summary>
            /// bg-navy
            /// </summary>
            Navy,

            /// <summary>
            /// bg-teal
            /// </summary>
            Teal,

            /// <summary>
            /// bg-purple
            /// </summary>
            Purple,

            /// <summary>
            /// bg-orange
            /// </summary>
            Orange,

            /// <summary>
            /// bg-maroon
            /// </summary>
            Maroon,

            /// <summary>
            /// bg-black
            /// </summary>
            Black
        }

        /// <summary>
        /// A mapping of GoalColors into CSS classes
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string BackgroundClassForColor(Color color)
        {
            switch (color)
            {
                case Color.LightBlue:
                    return "bg-light-blue";
                case Color.Aqua:
                    return "bg-aqua";
                case Color.Blue:
                    return "bg-blue";
                case Color.Green:
                    return "bg-green";
                case Color.Yellow:
                    return "bg-yellow";
                case Color.Red:
                    return "bg-red";
                case Color.Gray:
                    return "bg-gray";

                case Color.Navy:
                    return "bg-navy";
                case Color.Teal:
                    return "bg-teal";
                case Color.Purple:
                    return "bg-purple";
                case Color.Orange:
                    return "bg-orange";
                case Color.Maroon:
                    return "bg-maroon";
                case Color.Black:
                    return "bg-black";

                default:
                    return "bg-light-blue";
            }
        }
    }
}