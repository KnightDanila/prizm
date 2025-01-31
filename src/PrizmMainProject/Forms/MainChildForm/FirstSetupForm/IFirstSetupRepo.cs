﻿using Prizm.Data.DAL;
using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Security;
using Prizm.Data.DAL.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
{
    public interface IFirstSetupRepo : IDisposable
    {
        IUserRepository UserRepo { get; }
        IProjectRepository ProjectRepo { get; }
        ICertificateTypeRepository CertificateTypeRepo { get; }
        ISeamTypeRepository SeemTypeRepo { get; }
        IPermissionRepository PermissionRepo { get; }
        IRoleRepository RoleRepo { get; }
        ICategoryRepository CategoryRepo { get; }
        IJointOperationRepository JointOperationRepo { get; }
        IPipeTestRepository TestRepo { get; }
        IMillPipeSizeTypeRepository SizeTypeRepo { get; }
        IPlateManufacturerRepository PlateManRepo { get; }
        IHeatRepository HeatRepo { get; }
        IPlateRepository PlateRepo { get; }
        IPurchaseOrderRepository PurchaseRepo { get; }
        IRailcarRepository RailRepo { get; }
        IPipeRepository PipeRepo { get; }
        IInspectorRepository InspectorRepo { get; }
        IPipeTestResultRepository PipeTestResultRepo { get; }
        IWelderRepository WelderRepo { get; }
        IComponentTypeRepository ComponentTypeRepo { get; }
        IComponentRepository ComponentRepo { get; }
        IReleaseNoteRepository ReleaseRepo { get; }

        void Commit();
        void BeginTransaction();
    }
}
