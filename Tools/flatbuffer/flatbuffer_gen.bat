


echo off & color 0A

::指定起始文件夹

set SRCDIR="../../Msg/flatbuffer/"
set CSHARP_C_DSTDIR="../../Client/client/Assets/Scripts/Msg/"
set LUA_C_DSTDIR="../../Client/client/Assets/StreamingAssets/lua/msg/"
set LUA_S_DSTDIR="../../Server/msg/"
set LUA_PREFIX="3rd."
set LUA_MEMDATA_PREFIX="msg."

set LUA_C_DSTDIR_FROM_CSHARP_C_DSTDIR="../../StreamingAssets/lua/msg/"
set LUA_S_DSTDIR_FROM_LUA_C_DSTDIR="../../../../../../Server/msg/"

echo "--------------------------------------------------------------------------"
echo "SrcDir"
echo %SRCDIR%

echo "CSHARP_C_DSTDIR"
echo %CSHARP_C_DSTDIR%

echo "Lua_Client_DstDir"
echo %LUA_C_DSTDIR%

echo "Lua_Server_DstDir"
echo %LUA_S_DSTDIR%

echo "--------------------------------------------------------------------------"
echo "delete CSHARP_C_DSTDIR"
rd /s /q %CSHARP_C_DSTDIR%

echo "delete LUA_C_DSTDIR"
rd /s /q %LUA_C_DSTDIR%

echo "delete LUA_S_DSTDIR"
rd /s /q %LUA_S_DSTDIR%

:: 参数 /R 表示需要遍历子文件夹,去掉表示不遍历子文件夹

:: %%f 是一个变量,类似于迭代器,但是这个变量只能由一个字母组成,前面带上%%

:: 括号中是通配符,可以指定后缀名,*.*表示所有文件

echo "--------------------------------------------------------------------------"
for /R %SRCDIR% %%f in (*.fbs) do ( 
    echo %%f
    flatc --csharp -o %CSHARP_C_DSTDIR% %%f
    flatc --lua -o %LUA_C_DSTDIR% --lua-prefix %LUA_PREFIX% --lua-memdata-prefix %LUA_MEMDATA_PREFIX% %%f
    flatc --lua -o %LUA_S_DSTDIR% %%f
)

echo "--------------------------------------------------------------------------"
echo "svn add CSHARP_C_DSTDIR"
cd %CSHARP_C_DSTDIR%
svn add . --no-ignore --force

echo "svn add LUA_C_DSTDIR_FROM_CSHARP_C_DSTDIR"
cd %LUA_C_DSTDIR_FROM_CSHARP_C_DSTDIR%
svn add . --no-ignore --force

echo "svn add LUA_S_DSTDIR_FROM_LUA_C_DSTDIR"
cd %LUA_S_DSTDIR_FROM_LUA_C_DSTDIR%
svn add . --no-ignore --force

pause








