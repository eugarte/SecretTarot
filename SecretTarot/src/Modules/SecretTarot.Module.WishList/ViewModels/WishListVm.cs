﻿using cloudscribe.Pagination.Models;

namespace SecretTarot.Module.WishList.ViewModels
{
    public class WishListVm
    {
        public long Id { get; set; }

        public string SharingCode { get; set; }

        public PagedResult<WishListItemVm> Items { get; set; } = new PagedResult<WishListItemVm>();
    }
}
