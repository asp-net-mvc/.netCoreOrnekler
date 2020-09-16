using System;




    /// <summary>
    /// Business entity used to model items in a shopping cart
    /// </summary>
    [Serializable]
    public class CartItemInfo
    {

        // Internal member variables
        private int productId;
        private int quantity = 1;
        private string productName;
        private string type;
        private decimal price;
        private int categoryId;
        private string categoryName;
        

        /// <summary>
        /// Default constructor
        /// </summary>
        public CartItemInfo() { }

        /// <summary>
        /// Constructor with specified initial values
        /// </summary>
        /// <param name="itemId">Id of item to add to cart</param></param>
        /// <param name="name">Name of item</param>
        /// <param name="qty">Quantity to purchase</param>
        /// <param name="price">Price of item</param>
        /// <param name="type">Item type</param>	  
        /// <param name="categoryId">Parent category id</param>
        /// <param name="productId">Parent product id</param>
        public CartItemInfo(int productId, string productName, int qty, decimal price, string type, int categoryId, string categoryName)
        {
            this.productId = productId;
            this.productName = productName;
            this.quantity = qty;
            this.price = price;
            this.type = type;
            this.categoryId = categoryId;
            this.categoryName = categoryName;
            
        }

        // Properties
         public int ProductId
        {
             get{ return productId;}
             set{ productId = value;}
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal Subtotal
        {
            get { return (decimal)(this.quantity * this.price); }
        }

   
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string Type
        {
            get{return type;}
            set {type = value;}
        }
        public decimal Price
        {
            get { return price; }
            set { price = value;}
        }

        public int CategoryId
        {
            get{ return categoryId; }
            set{ categoryId = value;}
        }

        public string CategoryName
        {
            get{ return categoryName; }
            set{ categoryName = value;}
        }
       
    }