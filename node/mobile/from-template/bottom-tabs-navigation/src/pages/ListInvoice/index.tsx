import { useState, useEffect, useCallback } from 'react'
import { FlatList, Alert } from 'react-native';
import { Header } from '../../components/Header'
import { Container } from './styles'
import { ListCard } from '../../components/ListCard';

interface ListInvoiceProps {
  id: string,
  description: string,
  invoice_value: string,
  issue_Date: Date,
  client: string,
}

export function ListInvoice() {
  const [invoice, setInvoice] = useState<ListInvoiceProps[]>([])

  async function loadInvoice() {
  }

  function handleDeleteInvoice(id: string) {
    Alert.alert('Exclusão', 'Tem certeza?', [
      {
        text: 'Cancel',
        onPress: () => console.log('Cancel Pressed')
      },
      {
        text: 'OK',
        onPress: () => setInvoice(invoice =>
          invoice.filter(invoic => invoic.id !== id))
      },
    ])
  }

  useEffect(() => {
    loadInvoice()
  }, [])


  return (
    <Container>
      <Header title='Listagem dos Dados das NFs' />

      <FlatList
        showsVerticalScrollIndicator={false}
        data={invoice}
        keyExtractor={item => item.id}
        renderItem={({ item }) => (
          <ListCard
            item={item}
            onPress={() => handleDeleteInvoice(item.id)}
          />
        )}
      />
    </Container>
  )
}
