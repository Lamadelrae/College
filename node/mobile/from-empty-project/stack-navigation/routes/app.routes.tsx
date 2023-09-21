import * as React from "react";
import { NavigationContainer } from "@react-navigation/native";
import { createNativeStackNavigator } from "@react-navigation/native-stack";
import { Button, Text, View, StyleSheet, TextInput } from "react-native";

const Stack = createNativeStackNavigator();

export const Routes = () => {
  return (
    <NavigationContainer>
      <Stack.Navigator>
        <Stack.Screen name="Home" component={Login} />
        <Stack.Screen name="NewSubject" component={NewSubject} />
        <Stack.Screen name="Subjects" component={Subjects} />
        <Stack.Screen name="LogOut" component={LogOut} />
      </Stack.Navigator>
    </NavigationContainer>
  );
};

const Login = ({ navigation }) => {
  return (
    <View style={styles.container}>
      <Text style={styles.text}> Login</Text>
      <TextInput style={styles.input} placeholder="Email" />
      <Button
        title="Entrar"
        onPress={() => navigation.navigate("NewSubject")}
      />

      <Button
        title="Criar Login"
        onPress={() => navigation.navigate("LogOut")}
      />
    </View>
  );
};

const NewSubject = ({ navigation }) => {
  return (
    <View style={styles.container}>
      <Text style={styles.text}>Nova Disciplina</Text>
      <TextInput style={styles.input} placeholder="Disciplina" />
      <Button title="Criar" onPress={() => navigation.navigate("Subjects")} />
      <Button title="Voltar" onPress={() => navigation.goBack()} />
    </View>
  );
};

const Subjects = ({ navigation }) => {
  return (
    <View style={styles.container}>
      <Text style={styles.text}>Lista Disciplina</Text>
      <Text>Nome da disciplina</Text>
      <Button title="Voltar" onPress={() => navigation.goBack()} />
    </View>
  );
};

const LogOut = ({ navigation }) => {
  return (
    <View style={styles.container}>
      <Text style={styles.text}>LogOut</Text>
      <TextInput style={styles.input} placeholder="Email" />
      <Button title="Criar" onPress={() => navigation.goBack()} />
      <Button title="Voltar" onPress={() => navigation.goBack()} />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    paddingTop: 100,
    textAlign: "center",
    alignContent: "center",
    alignItems: "center",
  },
  input: {
    borderColor: "gray",
    width: "50%",
    borderWidth: 1,
    borderRadius: 10,
    padding: 10,
  },
  text: {
    fontFamily: "bold",
    fontSize: 40,
  },
});
