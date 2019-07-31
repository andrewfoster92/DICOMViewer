﻿
using DICOMcloud.Wado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;
using System.Web.Http.ValueProviders;
using DICOMcloud.Pacs;
using fo = Dicom;


namespace DICOMcloud.Wado
{
    public class DeleteRsRequestModelConverter : RsRequestModelConverter<WebDeleteRequest>
    {
        public DeleteRsRequestModelConverter ( )
        { }


        public override bool TryParse ( HttpRequestMessage request, ModelBindingContext bindingContext, out WebDeleteRequest result )
        {
            var studyParam    = bindingContext.ValueProvider.GetValue ("studyInstanceUID") ;
            var seriesParam   = bindingContext.ValueProvider.GetValue ("seriesInstanceUID") ;
            var instanceParam = bindingContext.ValueProvider.GetValue ("sopInstanceUID" ) ;


            result = null ;

            if ( null == studyParam  && 
                 null == seriesParam  && 
                 null == instanceParam  )
            {
                return false ;
            }
            else
            {
                result = new WebDeleteRequest ( ) 
                { 
                    Dataset     = new fo.DicomDataset ( ),
                    DeleteLevel = ObjectQueryLevel.Unknown 
                } ;

                if ( null != studyParam ) 
                { 
                    result.Dataset.Add ( fo.DicomTag.StudyInstanceUID, studyParam.AttemptedValue ) ; 
                    
                    result.DeleteLevel = ObjectQueryLevel.DICOM_STUDY ;
                }

                if ( null != seriesParam  ) 
                { 
                    result.Dataset.Add ( fo.DicomTag.StudyInstanceUID, seriesParam.AttemptedValue ) ;

                    result.DeleteLevel = ObjectQueryLevel.DICOM_SERIES ;
                }
                
                if ( null != instanceParam ) 
                { 
                    result.Dataset.Add ( fo.DicomTag.StudyInstanceUID, instanceParam.AttemptedValue ) ; 

                    result.DeleteLevel = ObjectQueryLevel.DICOM__OBJECT_INSTANCE ;
                }
            }

            return result.DeleteLevel != ObjectQueryLevel.Unknown ;
        }
   }
}
