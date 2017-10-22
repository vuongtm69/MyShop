using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vau.Data.Infrastructure;
using Vau.Data.Repositories;
using Vau.Model.Models;

namespace Vau.Services
{
    public interface IErrorService
    {
        Error Create(Error error);
        void SaveChange();
    }
    public class ErrorService : IErrorService
    {
        IUnitOfWork _unitOfWork;
        IErrorRepository _errorRepository;

        public ErrorService(IUnitOfWork unitOfWork, IErrorRepository errorRepository)
        {
            this._unitOfWork = unitOfWork;
            this._errorRepository = errorRepository;
        }
        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }
    }
}
