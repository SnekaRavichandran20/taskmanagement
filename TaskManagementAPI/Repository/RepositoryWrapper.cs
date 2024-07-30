using TaskManagementAPI.Contracts;
using TaskManagementSystem.Data;
using TaskManagementAPI.Repository;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly RepositoryContext _repoContext;

        private ITaskRepository _task;
        private IProjectRepository _project;
        private IUserRepository _user;
        private IProjectUserMappingRepository _projectUserMapping;
        private IUserCredentialRepository _userCredential;
        private IRefTermRepository _refTerm;
        private INoteRepository _note;
        private IAttachmentRepository _attachment;      

        public ITaskRepository Task
        {
            get
            {
                if (_task == null)
                {
                    _task = new TaskRepository(_repoContext);
                }
                return _task;
            }
        }

        public IProjectRepository Project
        {
            get
            {
                if (_project == null)
                {
                    _project = new ProjectRepository(_repoContext);
                }
                return _project;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }
                return _user;
            }
        }

        public IProjectUserMappingRepository ProjectUserMapping
        {
            get
            {
                if (_projectUserMapping == null)
                {
                    _projectUserMapping = new ProjectUserMappingRepository(_repoContext);
                }
                return _projectUserMapping;
            }
        }

        public IUserCredentialRepository UserCredential
        {
            get
            {
                if (_userCredential == null)
                {
                    _userCredential = new UserCredentialRepository(_repoContext);
                }
                return _userCredential;
            }
        }

        public IRefTermRepository RefTerm
        {
            get
            {
                if (_refTerm == null)
                {
                    _refTerm = new RefTermRepository(_repoContext);
                }
                return _refTerm;
            }
        }

        public INoteRepository Note
        {
            get
            {
                if (_note == null)
                {
                    _note = new NoteRepository(_repoContext);
                }
                return _note;
            }
        }

        public IAttachmentRepository Attachment
        {
            get
            {
                if (_attachment == null)
                {
                    _attachment = new AttachmentRepository(_repoContext);
                }
                return _attachment;
            }
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}