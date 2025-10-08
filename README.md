# Code-NT106.Q14.1-Lab01_24521762
LAB 1 - Windows Forms Application

**GIỚI THIỆU**

Dự án **Lab 1** ứng dụng Windows Forms được viết bằng C# .NET 8.0, bao gồm các bài tập thực hành từ Bài 1 đến Bài 8.

**YÊU CẦU HỆ THỐNG**

- **.NET 8.0 SDK** hoặc mới hơn
- **Windows 10/11** (vì sử dụng Windows Forms)
- **Visual Studio 2022** hoặc **Visual Studio Code** (khuyến nghị)
- **Git** (để clone repository)
 **CÀI ĐẶT VÀ CHẠY ỨNG DỤNG**

### **1. Clone Repository**
```bash
git clone <repository-url >
cd "lAB 1"
```

### **2. Kiểm tra .NET SDK**
```bash
dotnet --version
```
*Kết quả mong đợi: 8.0.x hoặc mới hơn*

### **3. Khôi phục Dependencies**
```bash
dotnet restore
```

### **4. Build Ứng Dụng**
```bash
# Build cho Debug mode
dotnet build

# Build cho Release mode
dotnet build --configuration Release

# Build và tối ưu hóa
dotnet build --configuration Release --verbosity minimal
```

### **5. Chạy Ứng Dụng**
```bash
# Chạy trực tiếp từ source code
dotnet run

# Chạy với configuration cụ thể
dotnet run --configuration Release

# Chạy với thông tin debug
dotnet run --verbosity detailed
```

### **6. Chạy từ Executable**
```bash
# Sau khi build, chạy file .exe
cd bin\Debug\net8.0-windows
WindowsFormsApp.exe

# Hoặc từ Release build
cd bin\Release\net8.0-windows
WindowsFormsApp.exe
```
 **CÁC BÀI TẬP TRONG ỨNG DỤNG**

| Bài | Tên Form | Chức năng chính |
|-----|----------|-----------------|
| **Bài 1** | `Bai1Form.cs` | Tính toán cơ bản |
| **Bài 2** | `Bai2Form.cs` | Xử lý chuỗi và text |
| **Bài 3** | `Bai3Form.cs` | Quản lý danh sách |
| **Bài 4** | `Bai4Form.cs` | Ticket Seller |
| **Bài 5** | `Bai5Form.cs` | Tính toán A và B (bảng cửu chương, giai thừa, lũy thừa) |
| **Bài 6** | `Bai6Form.cs` | Cung hoàng đạo |
| **Bài 7** | `Bai7Form.cs` | Quản lý dữ liệu điểm |
| **Bài 8** | `Bai8Form.cs` | Tương tác random món ăn |

 **CÁC LỆNH DOTNET HỮU ÍCH**

### **Build Commands**
```bash
# Build với thông tin chi tiết
dotnet build --verbosity normal

# Build và bỏ qua cảnh báo
dotnet build --verbosity quiet

# Build cho platform cụ thể
dotnet build --runtime win-x64

# Build và publish
dotnet publish --configuration Release --runtime win-x64 --self-contained true
```

### **Clean Commands**
```bash
# Xóa các file build
dotnet clean

# Xóa hoàn toàn (bao gồm obj, bin)
dotnet clean --verbosity detailed
```

### **Debug Commands**
```bash
# Chạy với debugger
dotnet run --configuration Debug

# Chạy với profiling
dotnet run --configuration Release --verbosity diagnostic

# Chạy với environment variables
dotnet run --environment Development
```

### **Lỗi thường gặp:**

#### **1. .NET SDK không tìm thấy**
```bash
# Cài đặt .NET 8.0 SDK từ: https://dotnet.microsoft.com/download
dotnet --info
```

#### **2. Lỗi build**
```bash
# Xóa cache và rebuild
dotnet clean
dotnet restore
dotnet build
```

#### **3. Lỗi Windows Forms không chạy**
```bash
# Kiểm tra target framework
dotnet --list-sdks
dotnet --list-runtimes
```

#### **4. Lỗi permissions**
```bash
# Chạy PowerShell as Administrator
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
```


