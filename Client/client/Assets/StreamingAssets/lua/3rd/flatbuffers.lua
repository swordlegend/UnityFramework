local m = {}

m.Builder = require("3rd.flatbuffers.builder").New
m.N = require("3rd.flatbuffers.numTypes")
m.view = require("3rd.flatbuffers.view")
m.binaryArray = require("3rd.flatbuffers.binaryarray")

return m

