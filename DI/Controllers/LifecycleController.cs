using System;
using ArchiectureFundamentals.Cases;
using Microsoft.AspNetCore.Mvc;

namespace ArchiectureFundamentals.Controllers
{
    public class LifecycleController : Controller
    {
        public OperationService OperationService {get;}
        public OperationService OperationService2 {get;}
        public LifecycleController(OperationService operationService, OperationService operationService2)
        {
            OperationService = operationService;
            OperationService2 = operationService2;
        }

        public string Index()
        {
            return
                "First Instance: " + Environment.NewLine +
                OperationService.Transient.OperationId + Environment.NewLine +
                OperationService.Scoped.OperationId + Environment.NewLine +
                OperationService.Singleton.OperationId + Environment.NewLine +
                OperationService.SingletonInstance.OperationId + Environment.NewLine +

                Environment.NewLine +
                Environment.NewLine +

                "Sec Instance: " + Environment.NewLine +
                OperationService2.Transient.OperationId + Environment.NewLine +
                OperationService2.Scoped.OperationId + Environment.NewLine +
                OperationService2.Singleton.OperationId + Environment.NewLine +
                OperationService2.SingletonInstance.OperationId + Environment.NewLine;
        }

    }
}