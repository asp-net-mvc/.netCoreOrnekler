using System;
using System.Collections.Generic;



    /// <summary>
    /// An object to represent a customer's shopping cart.
    /// </summary>
    [Serializable]
    public class Cart
    {

        // Internal storage for a cart	  
        private Dictionary<int, CartItemInfo> cartItems = new Dictionary<int, CartItemInfo>();

        /// <summary>
        /// Calculate the total for all the cartItems in the Cart
        /// </summary>
        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (CartItemInfo item in cartItems.Values)
                    total += item.Price * item.Quantity;
                return total;
            }
        }

        /// <summary>
        /// Update the quantity for item that exists in the cart
        /// </summary>
        /// <param name="itemId">Item Id</param>
        /// <param name="qty">Quantity</param>
        public void SetQuantity(int itemId, int qty)
        {
            cartItems[itemId].Quantity = qty;
        }

        /// <summary>
        /// Return the number of unique items in cart
        /// </summary>
        public int Count
        {
            get { return cartItems.Count; }
        }

        /// <summary>
        /// Add an item to the cart.
        /// When ItemId to be added has already existed, this method will update the quantity instead.
        /// </summary>
        /// <param name="itemId">Item Id of item to add</param>
        public void Add(int itemId)
        {
            CartItemInfo cartItem;
            if (!cartItems.TryGetValue(itemId, out cartItem))
            {
                cartItem = CartDataHelper.getCartItemInfo(Convert.ToInt32(itemId));
                if(cartItem.ProductId != -1) cartItems.Add(itemId, cartItem);
            }
            else cartItem.Quantity++;
        }

        /// <summary>
        /// Add an item to the cart.
        /// When ItemId to be added has already existed, this method will update the quantity instead.
        /// </summary>
        /// <param name="item">Item to add</param>
        public void Add(CartItemInfo item)
        {
            CartItemInfo cartItem;
            if (!cartItems.TryGetValue(item.ProductId, out cartItem))
                cartItems.Add(item.ProductId, item);
            else
                cartItem.Quantity += item.Quantity;
        }

        /// <summary>
        /// Remove item from the cart based on itemId
        /// </summary>
        /// <param name="itemId">ItemId of item to remove</param>
        public void Remove(int itemId)
        {
            cartItems.Remove(itemId);
        }

        /// <summary>
        /// Returns all items in the cart. Useful for looping through the cart.
        /// </summary>
        /// <returns>Collection of CartItemInfo</returns>
        public ICollection<CartItemInfo> CartItems
        {
            get { return cartItems.Values; }
        }

        /// <summary>
        /// Clear the cart
        /// </summary>
        public void Clear()
        {
            cartItems.Clear();
        }
    }
