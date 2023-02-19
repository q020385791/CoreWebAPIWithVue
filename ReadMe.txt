1.
安裝 Microsoft.AspNetCore.StaticFiles
安裝VueCLI npm install -g @vue/cli


2.Configure 加入 
app.UseDefaultFiles()
app.UseStaticFiles() 
代表讓此 Web API 專案能使用預設的檔案作為進入點，並使其能使用靜態檔案作為網頁的資源。


3.launchSettings.json 

profiles 
IIS Express
Docker 
加入
"launchUrl": "",

Web API 的專案範本預設一啟動會開啟 api/values 這個路徑，
為了避免這預設動作，可以修改 properties 下的 launchSettings.json 檔案，
將其中的 launchUrl 修改成空值。


4.
建立前端頁面進入點資料夾 並cd ./ClientApp   
輸入命令提示字元 vue create frontend 建立Vue專案 


開發上我們會將 ASP.NET Core 視為主要專案，Vue 則是負責前端開發、編譯的輔助專案，所以我們在編譯專案上，必須先編譯 Vue，產生前端程式碼至 wwwroot 中，接著再編譯 ASP.NET Core 專案，讓網站運行完整。

所以編譯時會需要兩個步驟：
執行 npm run build
執行 Visual Studio 中的啟動但不偵錯來運行專案

參考 https://blog.poychang.net/vue-cli-with-dotnet-core-api/