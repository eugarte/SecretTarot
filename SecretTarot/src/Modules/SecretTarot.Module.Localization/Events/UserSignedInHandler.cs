using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Core.Events;
using SecretTarot.Module.Core.Extensions;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.ShoppingCart.Events
{
    public class UserSignedInHandler : INotificationHandler<UserSignedIn>
    {
        private readonly IWorkContext _workContext;
        private readonly IRepositoryWithTypedId<User, long> _userRepository;

        public UserSignedInHandler(IWorkContext workContext, IRepositoryWithTypedId<User, long> userRepository)
        {
            _workContext = workContext;
            _userRepository = userRepository;
        }

        public async Task Handle(UserSignedIn user, CancellationToken cancellationToken)
        {
            var guestUser = await _workContext.GetCurrentUser();
            var signedInUser = await _userRepository.Query().SingleAsync(u => u.Id == user.UserId);
            signedInUser.Culture = guestUser.Culture;
            await _userRepository.SaveChangesAsync();
        }
    }
}
