﻿using AutoMapper;
using Premedia.Applications.Imaging.Dashboard.Application.ReadModels;
using Premedia.Applications.Imaging.Dashboard.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premedia.Applications.Imaging.Dashboard.Application.Mappings
{
    public class FilePathMapping : Profile
    {
        public FilePathMapping()
        {
            CreateMap<FilePathReadModel, FilePath>().ReverseMap();
        }

    }
}
