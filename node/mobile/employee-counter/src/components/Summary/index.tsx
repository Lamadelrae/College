import { Text, View } from "react-native";
import { styles } from "./styles";

type Props = {
  totalJunior: number;
  totalMiddle: number;
  totalSenior: number;
};

export function Summary({ totalJunior, totalMiddle, totalSenior }: Props) {
  return (
    <View style={styles.container}>
      <Text style={styles.header}>Totais de salário</Text>

      <View style={styles.text}>
        <Text>Dev Junior:</Text>
        <Text style={styles.value}>{totalJunior}</Text>
      </View>

      <View style={styles.text}>
        <Text>Dev Pleno:</Text>
        <Text style={styles.value}>{totalMiddle}</Text>
      </View>

      <View style={styles.text}>
        <Text>Dev Senior:</Text>
        <Text style={styles.value}>{totalSenior}</Text>
      </View>

    </View>
  );
}
