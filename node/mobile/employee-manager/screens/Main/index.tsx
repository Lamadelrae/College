import React, { useState } from "react";
import {
  View,
  Text,
  TextInput,
  FlatList,
  TouchableOpacity,
} from "react-native";
import { Styles } from "./styles";
import { Employee } from "../../models/Employee";
import { EmployeeItem } from "../../components/EmployeeItem";

export const EmployeeScreen = () => {
  const [employees, setEmployees] = useState<Employee[]>([]);
  const [name, setName] = useState<string>("");
  const [occupation, setOccupation] = useState<string>("");
  const [department, setDepartment] = useState<string>("");
  const [salary, setSalary] = useState<string>("");
  const [errors, setErrors] = useState<string[]>([]);

  const validateInputs = (): boolean => {
    setErrors([]);
    let isValid = true;

    if (!name.trim()) {
      setErrors((prevErrors) => [...prevErrors, "O campo nome é obrigatório"]);
      isValid = false;
    }

    if (!occupation.trim()) {
      setErrors((prevErrors) => [
        ...prevErrors,
        "O campo função é obrigatório",
      ]);
      isValid = false;
    }

    if (!department.trim()) {
      setErrors((prevErrors) => [...prevErrors, "O campo setor é obrigatório"]);
      isValid = false;
    }

    if (!salary.trim()) {
      setErrors((prevErrors) => [
        ...prevErrors,
        "O salário deve ser preenchido",
      ]);
      isValid = false;
    }

    var rawSalary = salary.replace(",", ".").replace("R$", "").trim();
    if (rawSalary && Number(rawSalary) <= 0) {
      setErrors((prevErrors) => [
        ...prevErrors,
        "O salário deve ser maior que 0",
      ]);
      isValid = false;
    }

    return isValid;
  };

  const formatValue = (val: string): string => {
    let num = val.replace(/\D/g, "");
    num = (Number(num) / 100).toFixed(2);
    return `R$ ${num.replace(".", ",")}`;
  };

  const addEmployee = () => {
    if (!validateInputs()) {
      return;
    }

    const newEmployee: Employee = { name, occupation, department, salary };
    setEmployees([...employees, newEmployee]);
    setName("");
    setOccupation("");
    setDepartment("");
    setSalary("");
    setErrors([]);
  };

  return (
    <View style={Styles.container}>
      <Text style={Styles.header}>Cadastro funcionários</Text>
      <View style={Styles.form}>
        <View style={Styles.inputContainer}>
          <TextInput
            style={Styles.input}
            placeholder="Digite o nome"
            value={name}
            autoCapitalize="words"
            onChangeText={setName}
            clearButtonMode="while-editing"
          />
        </View>
        <View style={Styles.inputContainer}>
          <TextInput
            style={Styles.input}
            placeholder="Digite a função"
            value={occupation}
            autoCapitalize="words"
            onChangeText={setOccupation}
            clearButtonMode="while-editing"
          />
        </View>
        <View style={Styles.inputContainer}>
          <TextInput
            style={Styles.input}
            placeholder="Digite o setor"
            value={department}
            onChangeText={setDepartment}
            clearButtonMode="while-editing"
          />
        </View>
        <View style={Styles.inputContainer}>
          <TextInput
            style={Styles.input}
            placeholder="R$ 0,00"
            keyboardType="numeric"
            value={salary}
            onChangeText={(value) => setSalary(formatValue(value))}
          />
        </View>
        <TouchableOpacity style={[Styles.button]} onPress={addEmployee}>
          <Text style={Styles.buttonText}>Adicionar</Text>
        </TouchableOpacity>
      </View>

      {errors.length > 0 && (
        <View style={Styles.errorList}>
          <FlatList
            data={errors}
            renderItem={(unit) => <Text style={Styles.error}>{unit.item}</Text>}
            keyExtractor={(item, index) => `${index}`}
          />
        </View>
      )}

      <View style={Styles.list}>
        <FlatList
          data={employees}
          renderItem={(unit) => <EmployeeItem employee={unit.item} />}
          keyExtractor={(item, index) => `${index}`}
        />
      </View>
    </View>
  );
};
