using System.Linq;

namespace Child_Universe.Models
{
    public class Toy
    {
        /// <summary>
        /// ID - unique indentifier for one toy. It's used when buying toy and doing other manupulations.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// It's small text that describes product.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// It's full large text that describes product.
        /// </summary>
        public string Describtion { get; set; }
        /// <summary>
        /// Array of tags is used when user sorts products by tags.
        /// </summary>
        public Utils.Tag[] Tags { get; set; }
        /// <summary>
        /// This string contains path to image. It's used to send photo of product to site.
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// It's price of product.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Return true if toy has tag and return false if it hasn't.
        /// </summary>
        /// <param name="tag">Filter param</param>
        /// <returns></returns>
        public bool ContainsTag(Utils.Tag tag)
        {
            return Tags.Contains(tag);
        }

        /// <summary>
        /// Method that checks if header of product contains some text.
        /// </summary>
        /// <param name="text">Text that's searching.</param>
        /// <returns>Returns true if contains and false if doesn't contain</returns>
        public bool ContainsTextHeader(string text)
        {
            return Name.ToLower().Contains(text.ToLower());
        }

        /// <summary>
        /// Method that checks if describtion of product contains some text.
        /// </summary>
        /// <param name="text">Text that's searching.</param>
        /// <returns>Returns true if contains and false if doesn't contain</returns>
        public bool ContainsTextDescribtion(string text)
        {
            return Describtion.ToLower().Contains(text.ToLower());
        }
    }
}