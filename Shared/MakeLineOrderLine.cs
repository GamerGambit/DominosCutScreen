﻿using System.Xml.Serialization;

namespace DominosCutScreen.Shared
{
    public class MakeLineOrderLine : CommonMakelineItem
    {
        /// <summary>
        /// When each item was bumped
        /// Number of entries is equal to `Quantity` - `ToBeMadeQuantity`
        /// </summary>
        [XmlArray, XmlArrayItem("dateTime")]
        public List<DateTime> BumpedTimes { get; set; }

        /// <summary>
        /// Cooking instructions. Also contains cash amount and phone number if its the first item in the order
        /// </summary>
        [XmlElement]
        public string Instructions { get; set; }

        /// <summary>
        /// Whether all items have been bumped
        /// true if `ToBeMadeQuantity` == 0
        /// </summary>
        [XmlElement]
        public bool IsBumped { get; set; }

        /// <summary>
        /// Which makeline this order belongs to
        /// </summary>
        /// @TODO confirm
        [XmlElement]
        public int MakelineCode { get; set; }

        /// <summary>
        /// Not sure what this is for since the Pizza Checker doesnt exist anymore.
        /// Maybe this is true if the item is sent back up to the makeline after being bumped
        /// </summary>
        /// @TODO confirm
        [XmlElement]
        public bool IsRemake { get; set; }

        /// <summary>
        /// Not entirely sure what this is for.
        /// I'm guessing its for sorting how the items appear on the makeline
        /// </summary>
        /// @TODO confirm
        [XmlElement]
        public int LineNumber { get; set; }

        /// <summary>
        /// No idea what this is for
        /// </summary>
        /// @TODO confirm
        [XmlElement]
        public bool IsPairedProduct { get; set; }

        /// <summary>
        /// Item category (Pizza, Bread, Extras, Potato, Wings, MDB)
        /// Seems to be the category thats printed on the bottom of the receipt
        /// </summary>
        [XmlElement]
        public string ProductCategory { get; set; }

        /// <summary>
        /// Seems to be for pizzas and MDB which shows what it is without the base
        /// e.g. Mini MDB Mac & Cheese instead of Mini Deep Mini MDB Mac & Cheese
        /// e.g. Simply Cheese instead of L XL Classic Simply Cheese
        /// </summary>
        [XmlElement]
        public string ProductDescription { get; set; }

        /// <summary>
        /// No idea what this is for
        /// Always seems to be 1?
        /// </summary>
        [XmlElement]
        public int ProductWeightedEffort { get; set; }

        /// <summary>
        /// How many of this item to make
        /// </summary>
        [XmlElement]
        public int Quantity { get; set; }

        /// <summary>
        /// How many of this item are left to bump
        /// </summary>
        [XmlElement]
        public int ToBeMadeQuantity { get; set; }

        /// <summary>
        /// For pizzas, this is the code for the pizza itself plus any additional changes.
        /// For MDB, this is the pizza + sides
        /// For sides, this is just the options (e.g. dipping sauces for tenders)
        /// e.g. 
        /// </summary>
        [XmlElement]
        public string ToppingCodes { get; set; }

        /// <summary>
        /// Full text version of `ToppingCodes`
        /// </summary>
        [XmlElement]
        public string ToppingDescriptions { get; set; }

        // ToppingPortionDescriptions

        /// <summary>
        /// No idea what this is for, seems to always be 0
        /// </summary>
        [XmlElement]
        public int TotalWeight { get; set; }

        // ToppingModifiedPizzaPartCodes
    }
}
