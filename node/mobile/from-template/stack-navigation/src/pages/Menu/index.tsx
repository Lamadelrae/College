import { Button } from "../../components/Button";
import { Container } from "./styles";

export function Menu({ navigation }) {
  return (
    <>
      <Container>
        <Button
          title="Dashboard"
          handleUser={() => {
            navigation.navigate("Dashboard");
          }}
        />

        <Button
          title="List"
          handleUser={() => {
            navigation.navigate("ListInvoice");
          }}
        />
      </Container>
    </>
  );
}
