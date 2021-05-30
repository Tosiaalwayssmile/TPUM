using System;
using WebsocketServerLogic.DTOs;

namespace WebsocketServerLogic.Services.CartService
{
    public interface ICartService
    {
        CartDTO AddBookToCart(Guid bookId, Guid userId);
        CartDTO RemoveBookFromCart(Guid bookId, Guid userId);
        decimal CalculateTotalPrice(Guid userId, string code);
        CartDTO GetCart(Guid userId);
    }
}