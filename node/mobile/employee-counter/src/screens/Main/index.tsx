import { FlatList, Text, View } from "react-native";
import { styles } from "./styles";
import { Summary } from "../../components/Summary";
import { Employee } from "../../components/Employee";
import { FontAwesome5 } from "@expo/vector-icons";

export function Main() {
  const employees = [
    { id: "202301", name: "Ana", occupation: "Dev Junior", salary: 2500.0 },
    { id: "202302", name: "Maria", occupation: "Dev Pleno", salary: 4500.0 },
    { id: "202303", name: "Rosa", occupation: "Dev Senior", salary: 6500.0 },
    { id: "202304", name: "Jose", occupation: "Dev Pleno", salary: 4500.0 },
    { id: "202305", name: "Mateus", occupation: "Dev Junior", salary: 2500.0 },
    { id: "202306", name: "Ricardo", occupation: "Dev Senior", salary: 6500.0 },
  ];

  function getTotalByOccupation(occupation: string): number {
    return employees
      .filter((employee) => employee.occupation === occupation)
      .map((employee) => employee.salary)
      .reduce((total, value) => (total += value));
  }

  return (
    <View style={styles.container}>
      <View style={styles.header}>
        <FontAwesome5 name="money-bill-wave-alt" size={24} color="black" />
        <Text
          style={{
            paddingLeft: 10,
          }}
        >
          Folha de pagamento
        </Text>
      </View>

      <Summary
        totalJunior={getTotalByOccupation("Dev Junior")}
        totalMiddle={getTotalByOccupation("Dev Pleno")}
        totalSenior={getTotalByOccupation("Dev Senior")}
      />

      <FlatList
        data={employees}
        renderItem={({ item }) => (
          <Employee
            id={item.id}
            name={item.name}
            occupation={item.occupation}
            salary={item.salary}
          />
        )}
        keyExtractor={(item) => item.id}
      />
    </View>
  );
}
