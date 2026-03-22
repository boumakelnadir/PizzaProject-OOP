# 🍕 Pizza Order System

## 📌 Overview
A professional, interactive desktop application built with C# and Windows Forms. This project simulates a real-world pizza ordering system, demonstrating a strong foundation in logic building, clean code practices, and event-driven programming. 

## 🚀 Features
- **Dynamic Price Calculation:** Automatically calculates the total price based on size, crust type, toppings, and dining options (Eat-In/Take-Out).
- **Real-Time Order Summary:** The UI instantly updates the order details and receipt as the user selects or changes their preferences.
- **UI State Management:** Prevents order modification after confirmation by intelligently locking the interface controls.
- **Smart Reset:** A one-click reset button to clear the current order, re-enable controls, and restore all default selections.
- **Clean Architecture:** Utilizes modular functions, encapsulation, and control `Tags` to keep the codebase maintainable, readable, and highly optimized.

## 🛠️ Technologies Used
- **Language:** C#
- **Framework:** .NET (Windows Forms)
- **IDE:** Visual Studio

## 🧠 Technical Highlights
- Implementation of control `Tags` for dynamic numerical value extraction without hardcoding prices.
- Advanced string manipulation (e.g., `.StartsWith()`, `.Substring()`) for clean output formatting.
- Efficient use of UI event handlers (like `CheckedChanged`) separated from core calculation methods.

📸 Screenshots & UI Preview
1. Initial State (Project Load)
When the application starts, it initializes all default values and calculates the starting price.
<img width="1129" height="620" alt="Initial Load" src="https://github.com/user-attachments/assets/e74694d0-3c82-4f4d-aab9-1b604f618e7a" />

2. Order Processing & Confirmation
The system handles the selection process and displays a confirmation message before finalizing the order.
<img width="1113" height="613" alt="Take Order" src="https://github.com/user-attachments/assets/042fb3d6-41f7-412f-80a7-f66b101e9f2e" />

3. Post-Order Interface Locking
After confirmation, the UI intelligently disables inputs to prevent accidental changes, demonstrating professional state management.
<img width="1112" height="608" alt="Order Success" src="https://github.com/user-attachments/assets/1a3fa526-deed-4acd-8c46-f1e7eb49df46" />

Note: Clicking the Reset Button will restore the form to its initial state, re-enabling all controls for a new order.

## 🛠️ How to Run
To run this project locally, follow these steps:
1. **Clone the repository:** `git clone https://github.com/boumakelnadir/PizzaProject-OOP.git`
2. **Open the Solution:** Locate the `PizzaProject.sln` file and open it using **Visual Studio 2022** (or newer).
3. **Restore Packages:** Visual Studio will automatically restore any dependencies.
4. **Build & Run:** Press `F5` or click the **Start** button to launch the application.

