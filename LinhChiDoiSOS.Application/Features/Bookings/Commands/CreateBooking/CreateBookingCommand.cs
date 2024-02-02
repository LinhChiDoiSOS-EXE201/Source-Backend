using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Bookings.Commands.CreateBooking
{
    public class CreateBookingCommand : IRequest<SOSResponse>
    {
        // theo nguyên tắc bussiness t đề ra, trả tiền xong rồi mới tạo booking
        public double? Price { get; set; }
        public string PaymentId { get; set; }
        public string CustomerId { get; set; }

        // comboCourse => premium
        public string? NameComboCourse { get; set; }
    }

    public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommand, SOSResponse>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public CreateBookingCommandHandler(ILinhChiDoiSOSDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<SOSResponse> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = new Booking
            {
                Price = request.Price,
                PaymentId = Guid.Parse(request.PaymentId),
                CustomerId = Guid.Parse(request.CustomerId)
            };
            _dbContext.Booking.Add(booking);

            var comboCourseExist = await _dbContext.ComboCourse.Where(c => c.Name == request.NameComboCourse).SingleOrDefaultAsync();
            if (comboCourseExist == null) {
                throw new NotFoundException("Does not exist ComboName");
            }
            var bookingDetail = new BookingDetail
            {
                BookingId = booking.Id,
                ComboCourseId = comboCourseExist.Id
            };
            _dbContext.BookingDetail.Add(bookingDetail);

            var customer = await _dbContext.Customer.Where(c => c.Id == Guid.Parse(request.CustomerId)).SingleOrDefaultAsync();
            if(customer == null) {
                throw new NotFoundException("Does not exist CustomerId");
            }
            customer.IsPaid = true;
            _dbContext.Customer.Update(customer);

            await _dbContext.SaveChangesAsync();
            return new SOSResponse
            {
                Message = "Create Successfully"
            };
        }
    }
}
