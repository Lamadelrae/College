import { StyleSheet } from "react-native";

export const Styles = StyleSheet.create({
  container: {
    padding: 25,
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
  },
  header: {
    padding: 20,
    fontSize: 20,
    fontWeight: "bold",
  },
  inputContainer: {
    flexDirection: "row",
    alignItems: "center",
    marginBottom: 10,
  },
  input: {
    flex: 1,
    borderWidth: 1,
    borderColor: "#ccc",
    padding: 10,
    borderRadius: 5,
    fontSize: 16,
  },
  form: {
    width: "80%",
    marginBottom: 20,
  },
  list: {
    width: "80%",
    flex: 1,
  },
  button: {
    backgroundColor: "#89CFF0",
    borderRadius: 5,
    padding: 10,
    alignItems: "center",
    marginTop: 10,
  },
  buttonText: {
    color: "#fff",
    fontSize: 16,
    fontWeight: "bold",
  },
  disabledButton: {
    opacity: 0.5,
  },
  error: {
    color: "red",
    fontSize: 12,
    marginTop: 5,
  },
  errorList: {
    flex: 1,
    flexGrow: 0,
    minHeight: 100,
    alignItems: "center",
  },
});
