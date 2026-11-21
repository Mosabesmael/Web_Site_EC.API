using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface
{
    public  interface ICartRpository
    {
        Task<Cart?> GetByUserIdAsync(int userId);

        Task AddAsync(Cart cart);
        Task AddItemCart(CartItem cartItem);

        Task UpdateItemAsync(CartItem cartItem);

        Task RemoveItemAsync(CartItem cartItem);


        Task ClearAsync(Cart cart);




    }
}
