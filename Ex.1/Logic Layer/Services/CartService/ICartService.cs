using System;
using DataLayer.Model;
using LogicLayer.DTOs;

namespace LogicLayer.Services.CartService
{
    public interface ICartService
    {
        CartDTO AddBookToCart(Guid bookId, Guid userId);
        CartDTO RemoveBookFromCart(Guid bookId, Guid userId);
        decimal CalculateTotalPrice(Guid userId, string code);
        CartDTO GetCart(Guid userId);
    }
}