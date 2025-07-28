# MyRazorProject

ASP.NET Core Razor Pages 專案 - 一個功能完整的書籍管理系統

## 📋 專案概述

這是一個使用 ASP.NET Core Razor Pages 開發的 Web 應用程式，實現了書籍管理系統的完整功能，包括 CRUD 操作、數學計算服務、以及用戶友好的界面設計。

## 🏗️ 專案架構

本專案採用多層架構設計：

### 主要組件

- **MyRazorWeb**: 主要的 Razor Pages Web 應用程式
- **MyModels**: 包含資料模型和驗證邏輯
- **MyServices**: 業務邏輯和資料存取服務

## ✨ 功能特色

### 📚 書籍管理系統
- ✅ 書籍列表瀏覽
- ✅ 新增書籍
- ✅ 編輯書籍資訊
- ✅ 查看書籍詳情
- ✅ 刪除書籍
- ✅ 書籍分類管理

### 🧮 數學計算服務
- ✅ 基本數學運算功能
- ✅ 服務注入架構

### 🔍 資料驗證
- ✅ 自訂驗證屬性
- ✅ 年份驗證 (CheckValidYear)
- ✅ 表單驗證

## 🛠️ 技術堆疊

- **框架**: ASP.NET Core 9.0
- **UI**: Razor Pages
- **前端**: Bootstrap 5, jQuery
- **驗證**: ASP.NET Core Data Annotations
- **依賴注入**: ASP.NET Core DI Container

## 📁 專案結構

### MyRazorWeb

- **Pages**: 包含所有 Razor Page
- **wwwroot**: 靜態檔案，如 CSS、JavaScript 和圖片
- **appsettings.json**: 應用程式設定檔
- **Program.cs**: 應用程式進入點

### MyModels

- **Book.cs**: 書籍資料模型
- **Author.cs**: 作者資料模型
- **Category.cs**: 書籍分類模型
- **IValidatableObject**: 自訂驗證邏輯介面

### MyServices

- **BookService.cs**: 書籍相關的業務邏輯
- **MathService.cs**: 數學計算服務
- **ValidationService.cs**: 驗證相關服務

## 🚀 快速開始

1. 確保已安裝 [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
2. 下載或 Clone 此專案
3. 在專案根目錄執行 `dotnet restore` 以還原相依套件
4. 執行 `dotnet run` 啟動應用程式
5. 在瀏覽器中開啟 `http://localhost:5000` 查看應用程式

## 📚 參考資料

- [ASP.NET Core Documentation](https://docs.microsoft.com/aspnet/core/?view=aspnetcore-9.0)
- [Razor Pages Documentation](https://docs.microsoft.com/aspnet/core/razor-pages/?view=aspnetcore-9.0)
- [Entity Framework Core Documentation](https://docs.microsoft.com/ef/core/?tabs=vs)
- [Bootstrap Documentation](https://getbootstrap.com/docs/5.0/getting-started/introduction/)

## 👥 貢獻

歡迎任何形式的貢獻！請提出問題、建議功能或提交程式碼變更請求。


