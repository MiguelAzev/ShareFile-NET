// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2015 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using ShareFile.Api.Client.Entities;

namespace ShareFile.Api.Client
{
    public partial interface IShareFileClient
    {
        IConnectorGroupsEntity ConnectorGroups { get; }
        IReportsEntity Reports { get; }
        IFolderTemplatesEntity FolderTemplates { get; }
        IAccessControlsEntity AccessControls { get; }
        IAccountsEntity Accounts { get; }
        IAsyncOperationsEntity AsyncOperations { get; }
        ICapabilitiesEntity Capabilities { get; }
        IFavoriteFoldersEntity FavoriteFolders { get; }
        IGroupsEntity Groups { get; }
        IItemsEntity Items { get; }
        IMetadataEntity Metadata { get; }
        ISessionsEntity Sessions { get; }
        ISharesEntity Shares { get; }
        IStorageCentersEntity StorageCenters { get; }
        IUsersEntity Users { get; }
        IZonesEntity Zones { get; }
    }

    public partial class ShareFileClient
    {
        private ShareFileClient()
        {
            ConnectorGroups = new ConnectorGroupsEntity(this);
            Reports = new ReportsEntity(this);
            FolderTemplates = new FolderTemplatesEntity(this);
            AccessControls = new AccessControlsEntity(this);
            Accounts = new AccountsEntity(this);
            AsyncOperations = new AsyncOperationsEntity(this);
            Capabilities = new CapabilitiesEntity(this);
            FavoriteFolders = new FavoriteFoldersEntity(this);
            Groups = new GroupsEntity(this);
            Items = new ItemsEntity(this);
            Metadata = new MetadataEntity(this);
            Sessions = new SessionsEntity(this);
            Shares = new SharesEntity(this);
            StorageCenters = new StorageCentersEntity(this);
            Users = new UsersEntity(this);
            Zones = new ZonesEntity(this);
        }

        public IConnectorGroupsEntity ConnectorGroups { get; private set; }
        public IReportsEntity Reports { get; private set; }
        public IFolderTemplatesEntity FolderTemplates { get; private set; }
        public IAccessControlsEntity AccessControls { get; private set; }
        public IAccountsEntity Accounts { get; private set; }
        public IAsyncOperationsEntity AsyncOperations { get; private set; }
        public ICapabilitiesEntity Capabilities { get; private set; }
        public IFavoriteFoldersEntity FavoriteFolders { get; private set; }
        public IGroupsEntity Groups { get; private set; }
        public IItemsEntity Items { get; private set; }
        public IMetadataEntity Metadata { get; private set; }
        public ISessionsEntity Sessions { get; private set; }
        public ISharesEntity Shares { get; private set; }
        public IStorageCentersEntity StorageCenters { get; private set; }
        public IUsersEntity Users { get; private set; }
        public IZonesEntity Zones { get; private set; }
    }
}