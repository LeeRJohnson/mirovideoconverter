//  MiroVideoConverter -- a super simple way to convert almost any video to MP4, 
//  Ogg Theora, or a specific phone or iPod.
//
//  Copyright 2010 Participatory Culture Foundation
//
//  This file is part of MiroVideoConverter.
//
//  MiroVideoConverter is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  MiroVideoConverter is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with MiroVideoConverter.  If not, see http://www.gnu.org/licenses/.

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mirosubs.Converter.Windows.VideoFormats;

namespace Mirosubs.Converter.Windows.Process {
    class VideoParameters {
        public float? AudioBitrate { get; set; }
        public float? VideoBitrate { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public VideoSize VideoSize {
            get {
                if (Width.HasValue && Height.HasValue)
                    return new VideoSize() {
                        Width = Width.Value,
                        Height = Height.Value
                    };
                else
                    return null;
            }
        }
    }
}
