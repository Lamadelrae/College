import React from "react";
import { View, Text } from "react-native";
import { Styles } from "./styles";
import { Employee } from "../../models/Employee";

export const EmployeeItem = ({ employee }: { employee: Employee }) => {
  return (
    <View style={Styles.employeeItem}>
      <Text style={Styles.employeeName}>Nome: {employee.name}</Text>
      <Text style={Styles.employeeOccupation}>
        Função: {employee.occupation}
      </Text>
      <View style={Styles.departmentAndSalaryContainer}>
        <Text style={Styles.employeeDepartment}>
          Setor: {employee.department}
        </Text>
        <Text style={Styles.employeeSalary}>Salário: {employee.salary}</Text>
      </View>
    </View>
  );
};
