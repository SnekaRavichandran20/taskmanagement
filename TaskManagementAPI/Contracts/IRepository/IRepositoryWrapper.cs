using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;
using TaskManagementAPI.Contracts;

namespace TaskManagementAPI.Contracts
{
    public interface IRepositoryWrapper
    {
        ITaskRepository Task { get; }
        IAttachmentRepository Attachment { get; }
        INoteRepository Note { get; }
        IProjectRepository Project { get; }
        IProjectUserMappingRepository ProjectUserMapping { get; }
        IRefTermRepository RefTerm { get; }
        IUserCredentialRepository UserCredential { get; }
        IUserRepository User { get; }
        void Save();
    }
}