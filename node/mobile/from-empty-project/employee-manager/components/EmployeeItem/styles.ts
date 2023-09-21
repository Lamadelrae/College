import { StyleSheet } from "react-native";

export const Styles = StyleSheet.create({
  employeeItem: {
    borderWidth: 1,
    borderColor: "#ccc",
    borderRadius: 5,
    padding: 10,
    marginBottom: 10,
    backgroundColor: "#D9E0E2",
  },
  employeeName: {
    fontSize: 16,
    fontWeight: "bold",
    flexWrap: 'wrap',
    flex: 1,
  },
  employeeOccupation: {
    fontSize: 14,
    flexWrap: 'wrap',
    flex: 1,
  },
  employeeDepartment: {
    fontSize: 14,
    flexWrap: 'wrap',
    flex: 1,
  },
  departmentAndSalaryContainer: {
    flexDirection: "row",
    flex: 1,
    alignItems: "center"
  },
  employeeSalary: {
    color: "#72bcd4",
    fontSize: 15,
    flexWrap: 'wrap',
    flex: 1,
    fontWeight: "bold",
  },
});
