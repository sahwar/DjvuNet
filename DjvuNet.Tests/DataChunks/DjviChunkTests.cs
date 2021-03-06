﻿using Xunit;
using DjvuNet.DataChunks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace DjvuNet.DataChunks.Tests
{
    public class DjviChunkTests
    {
        [Fact()]
        public void DjviChunkTest()
        {
            Mock<IDjvuReader> readerMock = new Mock<IDjvuReader>();
            readerMock.Setup(x => x.Position).Returns(1024);

            DjviChunk unk = new DjviChunk(readerMock.Object, null, null, null, 0);
            Assert.Equal<ChunkType>(ChunkType.Djvi, unk.ChunkType);
            Assert.Equal(ChunkType.Djvi.ToString(), unk.Name);
            Assert.Equal<long>(1024, unk.DataOffset);
        }
    }
}
