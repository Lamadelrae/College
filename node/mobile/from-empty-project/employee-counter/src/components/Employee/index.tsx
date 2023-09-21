import { Text, View } from "react-native";
import { styles } from "./styles";

type Props = {
  id: string;
  name: string;
  occupation: string;
  salary: number;
};

export function Employee(employee: Props) {
  return (
    <View style={styles.container}>
      <View style={styles.text}>
        <Text>Nome: </Text>
        <Text>{employee.name}</Text>
      </View>

      <View style={styles.text}>
        <Text>Função: </Text>
        <Text>{employee.occupation}</Text>
      </View>

      <View style={styles.text}>
        <Text>Salário: </Text>
        <Text>{employee.salary}</Text>

        <Text style={{ paddingLeft: 50 }}>Desconto: </Text>
        <Text style={{ color: "#FF5C5C" }}>0</Text>
      </View>

      <View style={styles.text}>
        <Text>Salário Líquido: </Text>
        <Text
          style={{
            fontWeight: "bold",
            color: "#189AB4",
          }}
        >
          {employee.salary}
        </Text>
      </View>
    </View>
  );
}
