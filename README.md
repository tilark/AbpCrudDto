# AbpCrudDto
在创建Abp Entity时，能够自动创建相应的模版文件代码，节省重复工作

# 安装

打开SiteTypes目录

输入：

```
dotnet new -i . 
```

# 使用

随便打开一个目录，输入

```
dotnet new abpcruddto -n ProductCategory -d=ProductCategories -p=ProductionManage
```

会在当前目录下方创建 ProductCategory目录，目录内有两个文件夹 ** SiteManage.Application，SiteManage.Core **

# 查看自定义参数
``dotnet new abpcruddto -h``

# 卸载

先用 dotnet new --uninstall  查看可卸载的template，会有命令提示

```
D:\netdev\AbpTemplate\AbpCrudDto> dotnet new --uninstall 
当前已安装项:
      模板:
         ABP CRUD Dto AppService (abpcruddto) C#
      卸载命令:
         dotnet new --uninstall D:\netdev\AbpTemplate\AbpCrudDto
```

按指令操作

# 下一步操作
制作成nuget包