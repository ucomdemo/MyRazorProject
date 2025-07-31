---
mode: agent
model: Claude Sonnet 4
tools: ['codebase','filesystem','playwright']
---


# 任務描述

## 目標
使用 Playwright MCP Server 整理網站內容

## 詳細需求

### 目標網站
- **URL**: https://www.uuu.com.tw/
- **頁面**: 網站首頁

### 任務內容
1. 使用 Playwright MCP Server 訪問目標網站
2. 提取和整理首頁內容
3. 將內容結構化並整理成 Markdown 格式

### 輸出檔案
- **檔案名稱**: `myweb.md`
- **存放位置**: 目前工作資料夾
- **格式**: Markdown

### 技術要求
- 使用 Playwright MCP Server 進行網頁抓取
- 確保內容結構清晰
- 保持原始資訊的完整性

## 執行步驟
1. 啟動 Playwright MCP Server
2. 導航至目標網站首頁
3. 擷取頁面內容
4. 整理並格式化內容
5. 生成 `myweb.md` 檔案
6. 儲存至指定位置