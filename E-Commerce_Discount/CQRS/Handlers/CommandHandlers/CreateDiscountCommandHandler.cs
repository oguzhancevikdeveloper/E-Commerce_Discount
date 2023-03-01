using E_Commerce_Discount.CQRS.Commands.Request;
using E_Commerce_Discount.CQRS.Commands.Response;
using E_Commerce_Discount.Model;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace E_Commerce_Discount.CQRS.Handlers.CommandHandlers
{
    public class CreateDiscountCommandHandler : IRequestHandler<CreateDiscountCommandRequest, CreateDiscountCommandResponse>
    {
        private readonly Context _context;
        public CreateDiscountCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<CreateDiscountCommandResponse> Handle(CreateDiscountCommandRequest request, CancellationToken cancellationToken)
        {
            var managerId = _context.ManagerTypes.FirstOrDefault(x => x.Id == request.ManagerTypeId).Id;
            var id = Guid.NewGuid();

            try
            {
                if (request == null && request.ManagerTypeId != managerId)
                {
                    return new CreateDiscountCommandResponse
                    {
                        IsSuccess = false,
                        Message = "İndirim oluşturma işlemi, gerçekleştirelememiştir!"
                    };
                }
                else
                {
                    _context.Discounts.Add(new()
                    {
                        Id = id,
                        Name = request.Name,
                        Amount = request.Amount,
                        StartDate = request.Start,
                        FinishDate = request.Finish,
                        ManagerTypeId = request.ManagerTypeId,
                        CategoryId = request.CategoryId,
                    });
                    _context.SaveChangesAsync();
                    return new CreateDiscountCommandResponse
                    {
                        IsSuccess = true,
                        Message = "İndirim oluşturma işlemi, başarılı bir şekilde gerçekleştirilmiştir."
                    };
                }
            }
            catch (Exception)
            {
                return new CreateDiscountCommandResponse
                {
                    IsSuccess = false,
                    Message = "İndirim oluşturma işlemi, gerçekleştirelememiştir!"

                };
            }

        }
    }
}
