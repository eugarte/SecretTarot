namespace SecretTarot.Module.WishList.Services
{
    public interface IWishListService
    {
        string GenerateSharingCode(long wishListId);
    }
}
