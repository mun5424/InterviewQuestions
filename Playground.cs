using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{

    class Playground
    {
        class UpdateRequest
        {
            public int ExternalId {get; protected set; }
            public int ObjectId {get; protected set; }
            public int VersionId {get; protected set; }

        protected object CreateUpdateRequest<T>()
        {
            var updateRequest = new UpdateRequest();
            updateRequest.ExternalId = 12;
            updateRequest.ObjectId = 2;
            updateRequest.VersionId = 1; 
            return (object) updateRequest;

        }
        }

        

    }
}
