# Đề tài

## Thành viên thực hiện

| STT | Họ và tên       | MSSV       | Vai trò              |
|-----|-----------------|------------|-----------------------|
| 1   | Lê Minh Diện    | 2200011115   | Lập trình gameplay |
| 3   | Nguyễn Thanh Duy| 220003790  |  Âm thanh, hiệu ứng |

## Mục tiêu của dự án

Thiết kế và xây dựng một trò chơi nhập vai 2D (2D RPG) bằng Unity, tập trung vào việc áp dụng các kiến thức về lập trình game, thiết kế hệ thống nhân vật, cơ chế chiến đấu, quản lý bản đồ và trải nghiệm người chơi. Dự án nhằm rèn luyện kỹ năng làm việc nhóm, quy trình phát triển game thực tế và khả năng xây dựng một sản phẩm game hoàn chỉnh từ ý tưởng đến bản demo có thể chơi được.

## Công nghệ sử dụng

- **Unity** — Game Engine chính để phát triển toàn bộ dự án
- **C#** — Ngôn ngữ lập trình chính trong Unity
- **Git & GitHub** — Quản lý phiên bản và làm việc nhóm

## Hướng dẫn cài đặt và chạy chương trình

### 1. Yêu cầu môi trường

- Cài đặt [Unity Hub](https://unity.com/download)
- Cài đặt Unity Editor (khuyến nghị phiên bản LTS gần nhất, ví dụ 2022.3 LTS hoặc mới hơn)
- Cài đặt [Git](https://git-scm.com/) để clone project

### 2. Clone project về máy

```bash
git clone https://github.com/leminhdiengithub/GCN-TCNet.git
```

### 3. Mở project bằng Unity Hub

1. Mở **Unity Hub**
2. Chọn **Open** → **Add project from disk**
3. Trỏ đến thư mục vừa clone về (thư mục chứa file `Assets/`, `Packages/`, `ProjectSettings/`)
4. Unity sẽ tự động import project (lần đầu có thể mất vài phút để tạo lại thư mục `Library/`)

### 4. Chạy chương trình

1. Sau khi Unity Editor mở project thành công, vào thư mục `Assets/Scenes/`
2. Mở scene chính (ví dụ: `MainMenu.unity` hoặc `Game.unity`)
3. Nhấn nút **Play ▶** ở phía trên cùng của Unity Editor để chạy thử game ngay trong Editor

### 5. Build ra file chạy (tuỳ chọn)

1. Vào **File → Build Settings**
2. Chọn nền tảng mong muốn (Windows, macOS, ...)
3. Nhấn **Build**, chọn thư mục lưu và chờ Unity build xong
4. Chạy file `.exe` (Windows) hoặc file thực thi tương ứng vừa được tạo ra

---

*README này sẽ được cập nhật khi dự án có thêm tính năng mới.*